using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;
using System.Reflection;

namespace Repositories.EFCore
{
    public class RepositoryContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Geo> Geos { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            List<Guid> geoIds = new()
            {
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
            };
            List<Guid> addressIds = new()
            {
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
            };
            List<Guid> companyIds = new List<Guid>()
            {
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),
                Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
            };
            builder.ApplyConfiguration(new AddressConfig(geoIds, addressIds));
            builder.ApplyConfiguration(new GeoConfig(geoIds));
            builder.ApplyConfiguration(new CompanyConfig(companyIds));
            builder.ApplyConfiguration(new UserConfig(addressIds, companyIds));

            builder.Entity<User>()
                .HasOne(u => u.Address)
                .WithMany()
                .HasForeignKey(u => u.AddressId)
                .HasConstraintName("FK_User_Address")
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany()
                .HasForeignKey(u => u.CompanyId)
                .HasConstraintName("FK_User_Company")
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Address>()
                .HasOne(a => a.Geo)
                .WithMany()
                .HasForeignKey(a => a.GeoId)
                .HasConstraintName("FK_Address_Geo")
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
