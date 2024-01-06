using Entities.DataTransferObjects.Admin;
using Entities.Models;

namespace Services.Contracts
{
    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUsers(bool trackChanges);
        Task<User> GetUserById(string userName, bool trackChanges);
        Task UpdateUser(string userName, AdminUpdateUserInformationsDto updateUserDto, bool trackChanges);
        Task DeleteUser(string userName, bool trackChanges);
    }
}
