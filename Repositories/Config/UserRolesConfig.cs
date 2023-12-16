using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UserRolesConfig : IEntityTypeConfiguration<IdentityUserRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
        {
            var UserRoles = new List<IdentityUserRole<int>>();
            foreach (int i in Enumerable.Range(1, 10))
            {
                UserRoles.Add(new IdentityUserRole<int>
                {
                    UserId = i,
                    RoleId = 1
                });
            }
            builder.HasData(
                UserRoles.ToArray()
                );
        }
    }
}
