using Entities.Models;

namespace Repositories.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Task<Address> GetAddressByIdAsync(Guid AddressId, bool trackChanges);
        Task CreateAddressAsync(Address Address);
        Task UpdateAddressAsync(Address Address);
    }
}
