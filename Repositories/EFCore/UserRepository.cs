using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task CreateUser(User user)
            => await CreateAsync(user);

        public async Task DeleteUser(User user)
            => await DeleteAsync(user);

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

        public async Task UpdateUser(User user)
            => await UpdateAsync(user);
    }
}
