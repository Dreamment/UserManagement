using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class GeoRepository : RepositoryBase<Geo>, IGeoRepository
    {
        public GeoRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task CreateGeoAsync(Geo geo)
            => await CreateAsync(geo);
    }
}
