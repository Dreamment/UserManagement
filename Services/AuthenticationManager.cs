﻿using AutoMapper;
using Entities.DataTransferObjects.Auth;
using Entities.Exceptions.BadRequest;
using Entities.Exceptions.Database;
using Entities.Exceptions.NotFound;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repositories.Contracts;
using Services.Contracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services
{
    public class AuthenticationManager : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly IRepositoryManager _repositoryManager;

        private User? _user;

        public AuthenticationManager(
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration,
            RoleManager<IdentityRole<int>> roleManager,
            IRepositoryManager repositoryManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _roleManager = roleManager;
            _repositoryManager = repositoryManager;
        }
        public async Task<string> CreateTokenAsync()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        public async Task<SignInResult> LoginUser(UserForAuthenticationDto userForAuthenticationDto)
        {
            if (userForAuthenticationDto.Email != null && userForAuthenticationDto.UserName != null ||
                userForAuthenticationDto.Email == null && userForAuthenticationDto.UserName == null)
                throw new TooMuchPropBadRequestException("You must give Email or Username");
            if (!string.IsNullOrEmpty(userForAuthenticationDto.Email))
                return await LoginUserWithEmail(userForAuthenticationDto.Email, userForAuthenticationDto.Password);
            else if (!string.IsNullOrEmpty(userForAuthenticationDto.UserName))
                return await LoginUserWithUserName(userForAuthenticationDto.UserName, userForAuthenticationDto.Password);
            throw new LoggingDatabaseException();
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            if (userForRegistrationDto.Address == null && userForRegistrationDto.AddressId == null ||
                userForRegistrationDto.Address != null && userForRegistrationDto.AddressId != null)
                throw new MissingPropBadRequestException("Address", "AddressId");
            if (userForRegistrationDto.Company == null && userForRegistrationDto.CompanyId == null ||
                userForRegistrationDto.Company != null && userForRegistrationDto.CompanyId != null)
                throw new MissingPropBadRequestException("Company", "CompanyId");
            var roles = await _roleManager.Roles.ToListAsync();
            List<string> stringRoles = roles.Select(r => r.Name).ToList();
            if (!stringRoles.Contains(userForRegistrationDto.Role))
                throw new RoleNotExistsDatabaseException(userForRegistrationDto.Role);

            if (await _userManager.FindByNameAsync(userForRegistrationDto.UserName) != null)
                throw new UserNameAlreadyRegisteredDatabaseException(userForRegistrationDto.UserName);

            var user = _mapper.Map<User>(userForRegistrationDto);
            if (user.Address != null)
            {
                user.Address.Id = Guid.NewGuid();
                user.Address.Geo.Id = Guid.NewGuid();
                user.AddressId = user.Address.Id;
                user.Address.GeoId = user.Address.Geo.Id;
                await _repositoryManager.Geo.CreateGeoAsync(user.Address.Geo);
                await _repositoryManager.Address.CreateAddressAsync(user.Address);
            }
            if (user.Company != null)
            {
                user.Company.Id = Guid.NewGuid();
                user.CompanyId = user.Company.Id;
                await _repositoryManager.Company.CreateCompanyAsync(user.Company);
            }
            var result = new IdentityResult();
            try
            {
                result = await _userManager.CreateAsync(user, userForRegistrationDto.Password);
                if (result.Succeeded)
                    result = await _userManager.AddToRoleAsync(user, userForRegistrationDto.Role);
                if (!result.Succeeded)
                    await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    await _repositoryManager.SaveAsync();
                return result;
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
        }

        private async Task<SignInResult> LoginUserWithEmail(string email, string password)
        {
            _user = await _userManager.FindByEmailAsync(email);
            if (_user == null)
                return SignInResult.Failed;
            if (_user.IsActive == ACTIVE.Deactive)
                throw new UserDeactiveDatabaseException(_user.UserName);
            var result = await _userManager.CheckPasswordAsync(_user, password);
            if (!result)
                return SignInResult.Failed;
            return SignInResult.Success;
        }

        private async Task<SignInResult> LoginUserWithUserName(string userName, string password)
        {
            _user = await _userManager.FindByNameAsync(userName);
            if (_user == null)
                return SignInResult.Failed;
            if (_user.IsActive == ACTIVE.Deactive)
                throw new UserDeactiveDatabaseException(_user.UserName);
            var result = await _userManager.CheckPasswordAsync(_user, password);
            if (!result)
                return SignInResult.Failed;
            return SignInResult.Success;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["secretKey"]);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);

            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            return new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expirationInMinutes"])),
                signingCredentials: signingCredentials);
        }
    }
}
