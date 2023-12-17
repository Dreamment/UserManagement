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
        private readonly ICacheService _cacheService;

        public UserManager(IRepositoryManager repositoryManager, IMapper mapper, ICacheService cacheService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _cacheService = cacheService;
        }

        public async Task<GetUserInformationsDto> GetUserInformationsAsync(string userName, bool trackChanges)
        {
            var userDto = await GetUserFromCacheAsync(userName, trackChanges);
            return userDto;
        }

        public async Task UpdateUserAddressWithExistingAddressAsync(string userName, Guid AddressId, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges);
            if (user.AddressId == AddressId)
                throw new Exception("You give same address with yours");
            var Address = await GetAddressInformationFromCacheAsync(AddressId, trackChanges)
                ?? throw new Exception("Address not found");
            user.AddressId = AddressId;
            user.Address = Address;

            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserAddressWithNewAddressAsync(string userName, UpdateUserAddressDto updateUserAddressDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            var Address = _mapper.Map<Address>(updateUserAddressDto);
            if (Address.Geo.Lat == user.Address.Geo.Lat &&
                Address.Geo.Lng == user.Address.Geo.Lng &&
                Address.Street == user.Address.Street &&
                Address.Suite == user.Address.Suite &&
                Address.City == user.Address.City &&
                Address.Zipcode == user.Address.Zipcode)
                throw new Exception("You give same address with yours");
            Address.Id = Guid.NewGuid();
            user.AddressId = Address.Id;
            user.Address = Address;
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserCompanyWithExistingCompanyAsync(string userName, Guid CompanyId, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user.CompanyId == CompanyId)
                throw new Exception("You give same company with yours");
            var company = await GetCompanyInformationFromCacheAsync(CompanyId, trackChanges)
                ?? throw new Exception("Company not found");
            user.CompanyId = CompanyId;
            user.Company = company;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserCompanyWithNewCompanyAsync(string userName, UpdateUserCompanyDto updateUserCompanyDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            var company = _mapper.Map<Company>(updateUserCompanyDto);
            if (company.Name == user.Company.Name &&
                company.CatchPhrase == user.Company.CatchPhrase &&
                company.Bs == user.Company.Bs)
                throw new Exception("You give same company with yours");
            company.Id = Guid.NewGuid();
            user.CompanyId = company.Id;
            user.Company = company;
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserEmailAsync(string userName, UpdateUserEmailDto updateUserEmailDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user.Email == updateUserEmailDto.Email)
                throw new Exception("You give same email with yours");
            var Email = await GetEmailFromCacheAsync(updateUserEmailDto.Email, trackChanges);
            if (Email != null)
                throw new Exception("Email already exists");
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserInformationsWithExistingCompanyOrAddressAsync(string userName, Guid? AddressId, Guid? CompanyId, 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            if (updateUserInformationsDto.UpdateUserAddressDto != null || updateUserInformationsDto.UpdateUserCompanyDto != null)
                throw new Exception("You can not give new address or company");
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                 ?? throw new Exception("User not found");
            if (AddressId == null && CompanyId == null)
                throw new Exception("You must give addressId or companyId");
            if (AddressId == null || CompanyId == null)
            {
                if (AddressId == null)
                    AddressId = user.AddressId;
                else
                    CompanyId = user.CompanyId;
            }
            if (user.AddressId == AddressId && user.CompanyId == CompanyId)
                throw new Exception("You give same address or company with yours");
            var Address = await GetAddressInformationFromCacheAsync(AddressId.Value, trackChanges)
                ?? throw new Exception("Address not found");
            var company = await GetCompanyInformationFromCacheAsync(CompanyId.Value, trackChanges)
                ?? throw new Exception("Company not found");
            if (updateUserInformationsDto.Name != null)
                user.Name = updateUserInformationsDto.Name;
            if (updateUserInformationsDto.Username != null)
            {
                user.UserName = updateUserInformationsDto.Username;
                user.NormalizedUserName = user.UserName.ToUpperInvariant();
            }
            if (updateUserInformationsDto.Email != null)
                user.Email = updateUserInformationsDto.Email;
            if (updateUserInformationsDto.Website != null)
                user.Website = updateUserInformationsDto.Website;
            if (updateUserInformationsDto.PhoneNumber != null)
                user.PhoneNumber = updateUserInformationsDto.PhoneNumber;
            user.AddressId = AddressId;
            user.CompanyId = CompanyId;
            user.Address = Address;
            user.Company = company;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserInformationsWithNewCompanyOrAddressAsync(string userName, 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user == _mapper.Map<User>(updateUserInformationsDto))
                throw new Exception("You give same informations with yours");
            if (updateUserInformationsDto.Name != null)
                user.Name = updateUserInformationsDto.Name;
            if (updateUserInformationsDto.Username != null)
            {
                user.UserName = updateUserInformationsDto.Username;
                user.NormalizedUserName = user.UserName.ToUpperInvariant();
            }
            if (updateUserInformationsDto.Email != null)
                user.Email = updateUserInformationsDto.Email;
            if (updateUserInformationsDto.Website != null)
                user.Website = updateUserInformationsDto.Website;
            if (updateUserInformationsDto.PhoneNumber != null)
                user.PhoneNumber = updateUserInformationsDto.PhoneNumber;
            if (updateUserInformationsDto.UpdateUserAddressDto != null)
            {
                var Address = _mapper.Map<Address>(updateUserInformationsDto.UpdateUserAddressDto);
                Address.Id = Guid.NewGuid();
                Address.Geo.Id = Guid.NewGuid();
                user.AddressId = Address.Id;
                Address.GeoId = Address.Geo.Id;
                user.Address = Address;
                await _repositoryManager.Geo.CreateGeoAsync(Address.Geo);
                await _repositoryManager.Address.CreateAddressAsync(Address);
            }
            if(updateUserInformationsDto.UpdateUserCompanyDto != null)
            {
                var company = _mapper.Map<Company>(updateUserInformationsDto.UpdateUserCompanyDto);
                company.Id = Guid.NewGuid();
                user.CompanyId = company.Id;
                user.Company = company;
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserNameAsync(string userName, UpdateUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user.Name == updateUserInformationsDto.Name)
                throw new Exception("You give same name with yours");
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserPasswordAsync(string userName, UpdateUserPasswordDto updateUserInformationsDto, bool trackChanges)
        {
            if (updateUserInformationsDto.OldPassword == updateUserInformationsDto.NewPassword)
                throw new Exception("Old password and new password can not be same");
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            var passwordHasher = new PasswordHasher<User>();
            if (user.PasswordHash == passwordHasher.HashPassword(user, updateUserInformationsDto.NewPassword))
                throw new Exception("You give same password with yours");
            if (user.PasswordHash != null)
            {
                if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, updateUserInformationsDto.OldPassword) == PasswordVerificationResult.Failed)
                    throw new Exception("Password is wrong");
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserPhoneNumberAsync(string userName, UpdateUserPhoneNumberDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user.PhoneNumber == updateUserInformationsDto.PhoneNumber)
                throw new Exception("You give same phone number with yours");
            var phoneNumber = await GetPhoneFromCacheAsync(updateUserInformationsDto.PhoneNumber, trackChanges);
            if (phoneNumber != null)
                throw new Exception("Phone number already exists");
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserWebSiteAsync(string userName, UpdateUserWebSiteDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            if (user.Website == updateUserInformationsDto.Website)
                throw new Exception("You give same website with yours");
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
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserUserNameAsync(string userName, UpdateUserUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            if (userName.ToUpperInvariant() == updateUserInformationsDto.UserName.ToUpperInvariant())
                throw new Exception("You give same user name with yours");

            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new Exception("User not found");
            var existingUser = await GetUserAllInformationsFromCacheAsync(updateUserInformationsDto.UserName, trackChanges);
            if (existingUser != null)
                throw new Exception("User name already exists");
            user.UserName = updateUserInformationsDto.UserName;
            user.NormalizedUserName = user.UserName.ToUpperInvariant();
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        private async Task<GetUserInformationsDto> GetUserFromCacheAsync(string userName, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"user-{userName}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByUserNameWithDetailsAsync(userName, trackChanges,
                    u => u.Address, u => u.Address.Geo, u => u.Company);
                var userDto = _mapper.Map<GetUserInformationsDto>(user);
                return userDto;
            });
        }

        private async Task<User> GetUserAllInformationsFromCacheAsync(string userName, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"user-all-{userName}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByUserNameWithDetailsAsync(userName, trackChanges,
                    u => u.Address, u => u.Address.Geo, u => u.Company);
                return user;
            });
        }

        private async Task<Address> GetAddressInformationFromCacheAsync(Guid AddressId, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"address-{AddressId}", async () =>
            {
                var Address = await _repositoryManager.Address.GetAddressByIdWithDetailsAsync(AddressId, trackChanges, a => a.Geo);
                return Address;
            });
        }

        private async Task<Company> GetCompanyInformationFromCacheAsync(Guid CompanyId, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"company-{CompanyId}", async () =>
            {
                var company = await _repositoryManager.Company.GetCompanyByIdAsync(CompanyId, trackChanges);
                return company;
            });
        }

        private async Task<string> GetEmailFromCacheAsync(string email, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"email-{email}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByEMailAsync(email, trackChanges);
                return user.Email;
            });
        }
        
        private async Task<string> GetPhoneFromCacheAsync(string phoneNumber, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"phone-{phoneNumber}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByPhoneNumberAsync(phoneNumber, trackChanges);
                return user.PhoneNumber;
            });
        }
    }
}
