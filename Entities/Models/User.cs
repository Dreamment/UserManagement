using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Models
{
    public enum ACTIVE { Active, Deactive};

    public class User : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        [AllowNull]
        [ForeignKey("Address")]
        public Guid? AddressId { get; set; }
        [AllowNull]
        [Url]
        public string? Website { get; set; }
        [AllowNull]
        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }

        public Address? Address { get; set; }
        public Company? Company { get; set; }

        public ACTIVE IsActive { get; set; } = ACTIVE.Active;
    }
}
