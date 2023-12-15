using Entities.Models;

namespace Repositories.Contracts
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        Task<Company> GetCompanyByIdAsync(Guid companyId, bool trackChanges);
        Task CreateCompanyAsync(Company company);
    }
}
