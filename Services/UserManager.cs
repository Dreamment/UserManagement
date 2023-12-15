using AutoMapper;
using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class UserManager : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public UserManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<GetUserInformationsDto> GetUserInformationsAsync(int userId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Company, u => u.Adress, u => u.Adress.Geo) ?? throw new Exception("User not found");
            var userDto = _mapper.Map<GetUserInformationsDto>(user);
            return userDto;
        }

        public async Task UpdateUserAdressWithExistingAdressAsync(int userId, Guid AdressId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Adress) ?? throw new Exception("User not found");
            var adress = await _repositoryManager.Adress.GetAdressByIdAsync(AdressId, trackChanges) ??
                throw new Exception("Adress not found");
            user.AdressId = AdressId;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserAddressWithNewAdressAsync(int userId, UpdateUserAddressDto updateUserAddressDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Adress) ?? throw new Exception("User not found");
            var adress = _mapper.Map<Adress>(updateUserAddressDto);
            adress.Id = new Guid();
            user.AdressId = adress.Id;
            await _repositoryManager.Adress.CreateAdressAsync(adress);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserCompanyWithExistingCompanyAsync(int userId, Guid CompanyId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Company) ?? throw new Exception("User not found");
            var company = await _repositoryManager.Company.GetCompanyByIdAsync(CompanyId, trackChanges) 
                ?? throw new Exception("Company not found");
            user.CompanyId = CompanyId;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserCompanyWithNewCompanyAsync(int userId, UpdateUserCompanyDto updateUserCompanyDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Company) ?? throw new Exception("User not found");
            var company = _mapper.Map<Company>(updateUserCompanyDto);
            company.Id = new Guid();
            user.CompanyId = company.Id;
            await _repositoryManager.Company.CreateCompanyAsync(company);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserEmailAsync(int userId, UpdateUserEmailDto updateUserEmailDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges) 
                ?? throw new Exception("User not found");
            user.Email = updateUserEmailDto.Email;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserInformationsAsync(int userId, UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Adress, u => u.Company, u => u.Adress.Geo)
                ?? throw new Exception("User not found");
            _mapper.Map(updateUserInformationsDto, user);
            await _repositoryManager.User.UpdateUserAsync(user);
            await _repositoryManager.Adress.UpdateAdressAsync(user.Adress);
            await _repositoryManager.Company.UpdateCompanyAsync(user.Company);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserNameAsync(int userId, UpdateUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges)
                ?? throw new Exception("User not found");
            user.Name = updateUserInformationsDto.Name;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserPasswordAsync(int userId, UpdateUserPasswordDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges)
                ?? throw new Exception("User not found");
            var passwordHasher = new PasswordHasher<User>();
            if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, updateUserInformationsDto.OldPassword) == PasswordVerificationResult.Failed)
                throw new Exception("Old password is incorrect");
            user.PasswordHash = passwordHasher.HashPassword(user, updateUserInformationsDto.NewPassword);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserPhoneNumberAsync(int userId, UpdateUserPhoneNumberDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges)
                ?? throw new Exception("User not found");
            user.PhoneNumber = updateUserInformationsDto.PhoneNumber;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserWebSiteAsync(int userId, UpdateUserWebSiteDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges)
                ?? throw new Exception("User not found");
            user.Website = updateUserInformationsDto.Website;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserUserNameAsync(int userId, UpdateUserUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdAsync(userId, trackChanges)
                ?? throw new Exception("User not found");
            user.UserName = updateUserInformationsDto.UserName;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
