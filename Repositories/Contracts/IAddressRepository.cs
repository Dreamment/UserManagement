using Entities.Models;
using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Task<Address> GetAddressByIdAsync(Guid AddressId, bool trackChanges);
        Task<Address> GetAddressByIdWithDetailsAsync(Guid AddressId, bool trackChanges, 
            params Expression<Func<Address, object>>[] includes);
        Task CreateAddressAsync(Address Address);
        Task UpdateAddressAsync(Address Address);
    }
}
