using Entities.DataTransferObjects.Create;
using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
namespace Services.Contracts
{
    public interface IUserService
    {
        Task<GetUserInformationsDto> GetUserInformationsAsync(int userId, bool trackChanges);
        Task UpdateUserNameAsync(int userId, UpdateUserNameDto updateUserNameDto, bool trackChanges);
        Task UpdateUserUserNameAsync(int userId, UpdateUserUserNameDto updateUserUserName, bool trackChanges);
        Task UpdateUserEmailAsync(int userId, UpdateUserEmailDto updateUserEmailDto, bool trackChanges);
        Task UpdateUserPasswordAsync(int userId, UpdateUserPasswordDto updateUserPasswordDto, bool trackChanges);
        Task UpdateUserPhoneNumberAsync(int userId, UpdateUserPhoneNumberDto updateUserPhoneNumberDto, bool trackChanges);
        Task UpdateUserAddressWithNewAdressAsync(int userId, UpdateUserAddressDto updateUserAddressDto, bool trackChanges);
        Task UpdateUserAdressWithExistingAdressAsync(int userId, Guid AdressId, bool trackChanges);
        Task UpdateUserWebSiteAsync(int userId, UpdateUserWebSiteDto updateUserWebSiteDto, bool trackChanges);
        Task UpdateUserCompanyWithNewCompanyAsync(int userId, UpdateUserCompanyDto updateUserCompanyDto, bool trackChanges);
        Task UpdateUserCompanyWithExistingCompanyAsync(int userId, Guid CompanyId, bool trackChanges);
        Task UpdateUserInformationsWtihNewCompanyOrAdressAsync(int userId, UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges);
        Task UpdateUserInformationsWithExistingCompanyOrAdressAsync(int userId, Guid AdressId, Guid CompanyId , 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges);

    }
}
