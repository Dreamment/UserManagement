using Entities.DataTransferObjects.Create;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Entities.DataTransferObjects.Auth
{
    public class UserForRegistrationDto
    {
        [Required]
        public string Name { get; set; }
        [AllowNull]
        public Guid? AddressId { get; set; }
        [AllowNull]
        public CreateAdressDto? Address { get; set; }
        [Url]
        [AllowNull]
        public string Website { get; set; }
        [AllowNull]
        public Guid? CompanyId { get; set; }
        [AllowNull]
        public CreateCompanyDto? Company { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [AllowNull]
        public string? Password { get; set; } 
    }
}
