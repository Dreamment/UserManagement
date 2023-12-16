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
                u => u.Company, u => u.Address, u => u.Address.Geo) ?? throw new Exception("User not found");
            var userDto = _mapper.Map<GetUserInformationsDto>(user);
            return userDto;
        }

        public async Task UpdateUserAddressWithExistingAddressAsync(int userId, Guid AddressId, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Address) ?? throw new Exception("User not found");
            var Address = await _repositoryManager.Address.GetAddressByIdAsync(AddressId, trackChanges) 
                ?? throw new Exception("Address not found");
            user.AddressId = AddressId;
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

        public async Task UpdateUserAddressWithNewAddressAsync(int userId, UpdateUserAddressDto updateUserAddressDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Address) ?? throw new Exception("User not found");
            var Address = _mapper.Map<Address>(updateUserAddressDto);
            Address.Id = new Guid();
            user.AddressId = Address.Id;
            await _repositoryManager.Address.CreateAddressAsync(Address);
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

        public async Task UpdateUserInformationsWithExistingCompanyOrAddressAsync(int userId, Guid AddressId, Guid CompanyId, 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Address, u => u.Company) ?? throw new Exception("User not found");
            var Address = await _repositoryManager.Address.GetAddressByIdAsync(AddressId, trackChanges) 
                ?? throw new Exception("Address not found");
            var company = await _repositoryManager.Company.GetCompanyByIdAsync(CompanyId, trackChanges)
                ?? throw new Exception("Company not found");
            _mapper.Map(updateUserInformationsDto, user);
            user.AddressId = AddressId;
            user.CompanyId = CompanyId;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateUserInformationsWtihNewCompanyOrAddressAsync(int userId, UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserByIdWithDetailsAsync(userId, trackChanges,
                u => u.Address, u => u.Company, u => u.Address.Geo)
                ?? throw new Exception("User not found");
            _mapper.Map(updateUserInformationsDto, user);
            if (updateUserInformationsDto.UpdateUserAddressDto != null)
            {
                var Address = _mapper.Map<Address>(updateUserInformationsDto.UpdateUserAddressDto);
                Address.Id = new Guid();
                user.AddressId = Address.Id;
                await _repositoryManager.Address.CreateAddressAsync(Address);
            }
            if(updateUserInformationsDto.UpdateUserCompanyDto != null)
            {
                var company = _mapper.Map<Company>(updateUserInformationsDto.UpdateUserCompanyDto);
                company.Id = new Guid();
                user.CompanyId = company.Id;
                await _repositoryManager.Company.CreateCompanyAsync(company);
            }
            await _repositoryManager.User.UpdateUserAsync(user);
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
            if (user.PasswordHash != null)
            {
                if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, updateUserInformationsDto.OldPassword) == PasswordVerificationResult.Failed)
                    throw new Exception("Old password is incorrect");
            }
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
