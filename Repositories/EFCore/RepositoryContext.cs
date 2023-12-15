using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Geo> Geos { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
