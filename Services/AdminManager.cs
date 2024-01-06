using AutoMapper;
using Entities.DataTransferObjects.Admin;
using Entities.Exceptions.BadRequest;
using Entities.Exceptions.Database;
using Entities.Exceptions.NotFound;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class AdminManager : IAdminService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ICacheService _cacheService;

        public AdminManager(IRepositoryManager repositoryManager, IMapper mapper, ICacheService cacheService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _cacheService = cacheService;
        }
        public async Task DeleteUser(string userName, bool trackChanges)
        {
            var user = await GetUserByUserNameFromCache(userName, trackChanges) ??
                throw new EntityNotFoundException(userName);
            user.IsActive = ACTIVE.Deactive;
            await _repositoryManager.User.UpdateUserAsync(user);
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception)
            {
                throw new SavingDatabaseException();
            }
            _cacheService.ClearAll();
        }

        public async Task<IEnumerable<User>> GetAllUsers(bool trackChanges)
        {
            var users = await GetAllUsersFromCache(trackChanges);
            return users ?? throw new EntityNotFoundException();
        }

        public async Task<User> GetUserById(string userName, bool trackChanges)
        {
            var user = await GetUserByUserNameFromCache(userName, trackChanges);
            return user ?? throw new EntityNotFoundException(userName);
        }

        public async Task UpdateUser(string userName, AdminUpdateUserInformationsDto updateUserDto, bool trackChanges)
        {
            var user = await GetUserByUserNameFromCache(userName, trackChanges) ??
                throw new EntityNotFoundException(userName);
            if (updateUserDto.UserName != null)
            {
                var userCheck = await GetUserByUserNameFromCache(updateUserDto.UserName, trackChanges);
                if (userCheck != null)
                    throw new AlreadyExistsDatabaseException("user name");
                user.UserName = updateUserDto.UserName;
                user.NormalizedUserName = updateUserDto.UserName.ToUpper();
            }
            if (updateUserDto.Email != null)
            {
                var userCheck = await GetUserByEmailFromCache(updateUserDto.Email, trackChanges);
                if (userCheck != null)
                    throw new AlreadyExistsDatabaseException("email");
                user.Email = updateUserDto.Email;
                user.NormalizedEmail = updateUserDto.Email.ToUpper();
                user.EmailConfirmed = false;
                user.TwoFactorEnabled = false;
            }
            if (updateUserDto.PhoneNumber != null)
            {
                var userCheck = await GetUserByPhoneNumberFromCache(updateUserDto.PhoneNumber, trackChanges);
                if (userCheck != null)
                    throw new AlreadyExistsDatabaseException("phone number");
                user.PhoneNumber = updateUserDto.PhoneNumber;
                user.PhoneNumberConfirmed = false;
                user.TwoFactorEnabled = false;
            }
            if (updateUserDto.Website != null)
                user.Website = updateUserDto.Website;
            if (updateUserDto.Password != null)
            {
                var passwordHasher = new PasswordHasher<User>();
                var hashedPassword = passwordHasher.HashPassword(user, updateUserDto.Password);
                if (hashedPassword == user.PasswordHash)
                    throw new SamePasswordBadRequestException();
                user.PasswordHash = hashedPassword;
            }
            if (updateUserDto.Address != null)
            {
                var address = _mapper.Map<Address>(updateUserDto.Address);
                address.Id = Guid.NewGuid();
                address.GeoId = Guid.NewGuid();
                address.Geo.Id = address.GeoId.Value;
                user.Address = address;
                user.AddressId = address.Id;
                await _repositoryManager.Address.CreateAddressAsync(address);
                await _repositoryManager.Geo.CreateGeoAsync(address.Geo);
            }
            if (updateUserDto.Company != null)
            {
                var company = _mapper.Map<Company>(updateUserDto.Company);
                company.Id = Guid.NewGuid();
                user.Company = company;
                user.CompanyId = company.Id;
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
            _cacheService.ClearAll();
        }

        private async Task<IEnumerable<User>> GetAllUsersFromCache(bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"all-users", async () =>
            {
                var user = await _repositoryManager.User.GetAllUsersWithDetailsAsync(trackChanges,
                    u => u.Address, u => u.Address.Geo, u => u.Company);
                return user;
            });
        }

        private async Task<User> GetUserByUserNameFromCache(string userName, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"user-all-{userName}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByUserNameAsync(userName, trackChanges);
                return user;
            });
        }
        private async Task<User> GetUserByEmailFromCache(string email, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"user-all-{email}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByEMailAsync(email, trackChanges);
                return user;
            });
        }
        private async Task<User> GetUserByPhoneNumberFromCache(string phoneNumber, bool trackChanges)
        {
            return await _cacheService.GetOrAddAsync($"user-all-{phoneNumber}", async () =>
            {
                var user = await _repositoryManager.User.GetUserByPhoneNumberAsync(phoneNumber, trackChanges);
                return user;
            });
        }
    }
}
