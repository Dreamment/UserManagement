using Repositories.Contracts;
using Repositories.EFCore;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;

            User = new UserRepository(_context);
            Address = new AddressRepository(_context);
            Company = new CompanyRepository(_context);
        }

        public IUserRepository User { get; }
        public IAddressRepository Address { get; }
        public ICompanyRepository Company { get; }

        public Task SaveAsync()
            => _context.SaveChangesAsync();
    }
}
