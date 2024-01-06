using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            builder.HasData(
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
        }
    }
}
