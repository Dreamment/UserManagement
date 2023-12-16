using AutoMapper;
using Entities.DataTransferObjects.Auth;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
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

        private User? _user;
        public AuthenticationManager(
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }
        public string CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var tokenOptions = GenerateTokenOptions(signingCredentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        public async Task<SignInResult> LoginUser(UserForAuthenticationDto userForAuthenticationDto)
        {
            if (!string.IsNullOrEmpty(userForAuthenticationDto.Email))
                return await LoginUserWithEmail(userForAuthenticationDto.Email, userForAuthenticationDto.Password);
            else if (!string.IsNullOrEmpty(userForAuthenticationDto.UserName))
                return await LoginUserWithUserName(userForAuthenticationDto.UserName, userForAuthenticationDto.Password);
            else
                return SignInResult.NotAllowed;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            if (await _userManager.FindByNameAsync(userForRegistrationDto.UserName) != null)
                throw new Exception($"User {userForRegistrationDto.UserName} is already registered");

            var user = _mapper.Map<User>(userForRegistrationDto);
            try
            {
                return await _userManager.CreateAsync(user, userForRegistrationDto.Password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<SignInResult> LoginUserWithEmail(string email, string password)
        {
            _user = await _userManager.FindByEmailAsync(email);
            if (_user == null)
                return SignInResult.Failed;
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

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            return new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: new List<Claim> { new(ClaimTypes.Name, _user.UserName) },
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expirationInMinutes"])),
                signingCredentials: signingCredentials);
        }
    }
}
