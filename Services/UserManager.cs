using AutoMapper;
using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
using Entities.Exceptions.BadRequest;
using Entities.Exceptions.Database;
using Entities.Exceptions.NotFound;
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
                throw new SameObjectBadRequestException("address");
            var Address = await GetAddressInformationFromCacheAsync(AddressId, trackChanges)
                ?? throw new EntityNotFoundException("address", AddressId);
            user.AddressId = AddressId;
            user.Address = Address;

            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserAddressWithNewAddressAsync(string userName, UpdateUserAddressDto updateUserAddressDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            var Address = _mapper.Map<Address>(updateUserAddressDto);
            if (Address.Geo.Lat == user.Address.Geo.Lat &&
                Address.Geo.Lng == user.Address.Geo.Lng &&
                Address.Street == user.Address.Street &&
                Address.Suite == user.Address.Suite &&
                Address.City == user.Address.City &&
                Address.Zipcode == user.Address.Zipcode)
                throw new SameObjectBadRequestException("address");
            Address.Id = Guid.NewGuid();
            user.AddressId = Address.Id;
            user.Address = Address;
            await _repositoryManager.Address.CreateAddressAsync(Address);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserCompanyWithExistingCompanyAsync(string userName, Guid CompanyId, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user.CompanyId == CompanyId)
                throw new SameObjectBadRequestException("company");
            var company = await GetCompanyInformationFromCacheAsync(CompanyId, trackChanges)
                ?? throw new EntityNotFoundException("company",CompanyId);
            user.CompanyId = CompanyId;
            user.Company = company;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserCompanyWithNewCompanyAsync(string userName, UpdateUserCompanyDto updateUserCompanyDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            var company = _mapper.Map<Company>(updateUserCompanyDto);
            if (company.Name == user.Company.Name &&
                company.CatchPhrase == user.Company.CatchPhrase &&
                company.Bs == user.Company.Bs)
                throw new SameObjectBadRequestException("company");
            company.Id = Guid.NewGuid();
            user.CompanyId = company.Id;
            user.Company = company;
            await _repositoryManager.Company.CreateCompanyAsync(company);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception) 
            { 
                throw new SavingDatabaseException(); 
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserEmailAsync(string userName, UpdateUserEmailDto updateUserEmailDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user.Email == updateUserEmailDto.Email)
                throw new SameObjectBadRequestException("E-Mail");
            var Email = await GetEmailFromCacheAsync(updateUserEmailDto.Email, trackChanges);
            if (Email != null)
                throw new AlreadyExistsDatabaseException("email");
            user.Email = updateUserEmailDto.Email;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserInformationsWithExistingCompanyOrAddressAsync(string userName, Guid? AddressId, Guid? CompanyId, 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            if (updateUserInformationsDto.UpdateUserAddressDto != null || updateUserInformationsDto.UpdateUserCompanyDto != null)
                throw new TooMuchPropBadRequestException("You can not give new address or company");
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                 ?? throw new EntityNotFoundException(userName);
            if (AddressId == null && CompanyId == null)
                throw new NotEnoughPropBadRequestException("You must give addressId or companyId");
            if (AddressId == null || CompanyId == null)
            {
                if (AddressId == null)
                    AddressId = user.AddressId;
                else
                    CompanyId = user.CompanyId;
            }
            if (user.AddressId == AddressId && user.CompanyId == CompanyId)
                throw new SameObjectBadRequestException("address or company");
            var Address = await GetAddressInformationFromCacheAsync(AddressId.Value, trackChanges)
                ?? throw new EntityNotFoundException("address", AddressId);
            var company = await GetCompanyInformationFromCacheAsync(CompanyId.Value, trackChanges)
                ?? throw new EntityNotFoundException("company", CompanyId);
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
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserInformationsWithNewCompanyOrAddressAsync(string userName, 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user == _mapper.Map<User>(updateUserInformationsDto))
                throw new SameObjectBadRequestException("informations");
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
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserNameAsync(string userName, UpdateUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user.Name == updateUserInformationsDto.Name)
                throw new SameObjectBadRequestException("name");
            user.Name = updateUserInformationsDto.Name;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserPasswordAsync(string userName, UpdateUserPasswordDto updateUserInformationsDto, bool trackChanges)
        {
            if (updateUserInformationsDto.OldPassword == updateUserInformationsDto.NewPassword)
                throw new SamePasswordBadRequestException();
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            var passwordHasher = new PasswordHasher<User>();
            if (user.PasswordHash == passwordHasher.HashPassword(user, updateUserInformationsDto.NewPassword))
                throw new SameObjectBadRequestException("password");
            if (user.PasswordHash != null)
            {
                if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, updateUserInformationsDto.OldPassword) == PasswordVerificationResult.Failed)
                    throw new PasswordWrongBadRequestException();
            }
            user.PasswordHash = passwordHasher.HashPassword(user, updateUserInformationsDto.NewPassword);
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserPhoneNumberAsync(string userName, UpdateUserPhoneNumberDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user.PhoneNumber == updateUserInformationsDto.PhoneNumber)
                throw new SameObjectBadRequestException("phone number");
            var phoneNumber = await GetPhoneFromCacheAsync(updateUserInformationsDto.PhoneNumber, trackChanges);
            if (phoneNumber != null)
                throw new AlreadyExistsDatabaseException("phone number");
            user.PhoneNumber = updateUserInformationsDto.PhoneNumber;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserWebSiteAsync(string userName, UpdateUserWebSiteDto updateUserInformationsDto, bool trackChanges)
        {
            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            if (user.Website == updateUserInformationsDto.Website)
                throw new SameObjectBadRequestException("web site");
            user.Website = updateUserInformationsDto.Website;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            await _cacheService.ClearAsync($"user-{userName}");
            await _cacheService.ClearAsync($"user-all-{userName}");
        }

        public async Task UpdateUserUserNameAsync(string userName, UpdateUserUserNameDto updateUserInformationsDto, bool trackChanges)
        {
            if (userName.ToUpperInvariant() == updateUserInformationsDto.UserName.ToUpperInvariant())
                throw new EntityNotFoundException(userName);

            var user = await GetUserAllInformationsFromCacheAsync(userName, trackChanges)
                ?? throw new EntityNotFoundException(userName);
            var existingUser = await GetUserAllInformationsFromCacheAsync(updateUserInformationsDto.UserName, trackChanges);
            if (existingUser != null)
                throw new AlreadyExistsDatabaseException("user name");
            user.UserName = updateUserInformationsDto.UserName;
            user.NormalizedUserName = user.UserName.ToUpperInvariant();
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
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
