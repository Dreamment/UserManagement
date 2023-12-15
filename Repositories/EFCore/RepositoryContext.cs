using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Geo> Geos { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
