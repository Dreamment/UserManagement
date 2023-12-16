using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task CreateAddressAsync(Address Address)
            => await CreateAsync(Address);

        public async Task<Address> GetAddressByIdAsync(Guid AddressId, bool trackChanges)
        {
            var Address = await FindByConditionAsync(a => a.Id.Equals(AddressId), trackChanges);
            return Address.FirstOrDefault();
        }

        public async Task UpdateAddressAsync(Address Address)
            => await UpdateAsync(Address);
    }
}
