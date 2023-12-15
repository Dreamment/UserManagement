using Entities.Models;

namespace Repositories.Contracts
{
    public interface IAdressRepository : IRepositoryBase<Adress>
    {
        Task<Adress> GetAdressByIdAsync(Guid adressId, bool trackChanges);
        Task CreateAdressAsync(Adress adress);
        Task UpdateAdressAsync(Adress adress);
    }
}
