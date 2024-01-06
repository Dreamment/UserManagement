using Entities.Models;
using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.EFCore
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task CreateUserAsync(User user)
            => await CreateAsync(user);

        public async Task DeleteUserAsync(User user)
            => await DeleteAsync(user);

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
            => await FindAllAsync(trackChanges);

        public Task<IEnumerable<User>> GetAllUsersWithDetailsAsync(bool trackChanges, params Expression<Func<User, object>>[] includes)
            => FindAllWithDetailsAsync(trackChanges, includes);

        public async Task<User> GetUserByEMailAsync(string email, bool trackChanges)
        {
            var user = await FindByConditionAsync(u => u.Email.Equals(email), trackChanges);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByEmailWithDetailsAsync(string email, bool trackChanges, params Expression<Func<User, object>>[] includes)
        {
            var user = await FindByConditionWithDetailsAsync(u => u.Email.Equals(email), trackChanges, includes);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByIdAsync(int userId, bool trackChanges)
        {
            var user = await FindByConditionAsync(u => u.Id.Equals(userId), trackChanges);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByIdWithDetailsAsync(int userId, bool trackChanges, params Expression<Func<User, object>>[] includes)
        {
            var user = await FindByConditionWithDetailsAsync(u => u.Id.Equals(userId), trackChanges, includes);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges)
        {
            var user = await FindByConditionAsync(u => u.PhoneNumber.Equals(phoneNumber), trackChanges);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByUserNameAsync(string userName, bool trackChanges)
        {
            var user = await FindByConditionAsync(u => u.UserName.Equals(userName), trackChanges);
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserByUserNameWithDetailsAsync(string userName, bool trackChanges, params Expression<Func<User, object>>[] includes)
        {
            var user = await FindByConditionWithDetailsAsync(u => u.UserName.Equals(userName), trackChanges, includes);
            return user.FirstOrDefault();
        }

        public async Task UpdateUserAsync(User user)
            => await UpdateAsync(user);
    }
}
