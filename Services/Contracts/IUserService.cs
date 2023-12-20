using Entities.DataTransferObjects.Create;
using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
namespace Services.Contracts
{
    public interface IUserService
    {
        Task<GetUserInformationsDto> GetUserInformationsAsync(string userName, bool trackChanges);
        Task UpdateUserNameAsync(string userName, UpdateUserNameDto updateUserNameDto, bool trackChanges);
        Task UpdateUserUserNameAsync(string userName, UpdateUserUserNameDto updateUserUserName, bool trackChanges);
        Task UpdateUserEmailAsync(string userName, UpdateUserEmailDto updateUserEmailDto, bool trackChanges);
        Task UpdateUserPasswordAsync(string userName, UpdateUserPasswordDto updateUserPasswordDto, bool trackChanges);
        Task UpdateUserPhoneNumberAsync(string userName, UpdateUserPhoneNumberDto updateUserPhoneNumberDto, bool trackChanges);
        Task UpdateUserAddressWithNewAddressAsync(string userName, UpdateUserAddressDto updateUserAddressDto, bool trackChanges);
        Task UpdateUserAddressWithExistingAddressAsync(string userName, Guid AddressId, bool trackChanges);
        Task UpdateUserWebSiteAsync(string userName, UpdateUserWebSiteDto updateUserWebSiteDto, bool trackChanges);
        Task UpdateUserCompanyWithNewCompanyAsync(string userName, UpdateUserCompanyDto updateUserCompanyDto, bool trackChanges);
        Task UpdateUserCompanyWithExistingCompanyAsync(string userName, Guid CompanyId, bool trackChanges);
        Task UpdateUserInformationsWithNewCompanyOrAddressAsync(string userName, UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges);
        Task UpdateUserInformationsWithExistingCompanyOrAddressAsync(string userName, Guid? AddressId, Guid? CompanyId , 
            UpdateUserInformationsDto updateUserInformationsDto, bool trackChanges);
        Task DeactivateUserAsync(string userName, bool trackChanges);

    }
}
