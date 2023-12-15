using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class AdressRepository : RepositoryBase<Adress>, IAdressRepository
    {
        public AdressRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task CreateAdressAsync(Adress adress)
            => await CreateAsync(adress);

        public async Task<Adress> GetAdressByIdAsync(Guid adressId, bool trackChanges)
        {
            var adress = await FindByConditionAsync(a => a.Id.Equals(adressId), trackChanges);
            return adress.FirstOrDefault();
        }
    }
}
