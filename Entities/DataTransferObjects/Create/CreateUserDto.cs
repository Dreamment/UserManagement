using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Entities.DataTransferObjects.Create
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; }
        [AllowNull]
        public Guid AdressId { get; set; }
        [Url]
        [AllowNull]
        public string Website { get; set; }
        [AllowNull]
        public Guid CompanyId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        public string? Password { get; set; }
    }
}
