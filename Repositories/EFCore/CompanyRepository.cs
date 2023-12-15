using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task CreateCompanyAsync(Company company)
            => await CreateAsync(company);

        public async Task<Company> GetCompanyByIdAsync(Guid companyId, bool trackChanges)
        {
            var company = await FindByConditionAsync(c => c.Id.Equals(companyId), trackChanges);
            return company.FirstOrDefault();
        }
    }
}
