using Entities.Models;

namespace Repositories.Contracts
{
    public interface IGeoRepository : IRepositoryBase<Geo>
    {
        Task CreateGeoAsync(Geo geo);
    }
}
