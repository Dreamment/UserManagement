﻿using Repositories.Contracts;
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
            Adress = new AdressRepository(_context);
            Company = new CompanyRepository(_context);
        }

        public IUserRepository User { get; }
        public IAdressRepository Adress { get; }
        public ICompanyRepository Company { get; }

        public Task SaveAsync()
            => _context.SaveChangesAsync();
    }
}
