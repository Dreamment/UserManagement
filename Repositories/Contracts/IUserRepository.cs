using Entities.Models;
using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> GetUserByIdAsync(int userId, bool trackChanges);
        Task<User> GetUserByIdWithDetailsAsync(int userId, bool trackChanges, params Expression<Func<User, object>>[] includes);
        Task<User> GetUserByEMailAsync(string email, bool trackChanges);
        Task<User> GetUserByEmailWithDetailsAsync(string email, bool trackChanges, params Expression<Func<User, object>>[] includes);
        Task<User> GetUserByUserNameAsync(string userName, bool trackChanges);
        Task<User> GetUserByUserNameWithDetailsAsync(string userName, bool trackChanges, params Expression<Func<User, object>>[] includes);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);

    }
}
