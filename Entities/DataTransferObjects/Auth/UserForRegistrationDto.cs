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
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z0-9!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]{8,}$", 
            ErrorMessage = "Password must contain at least 1 lowercase letter, 1 uppercase letter, 1 digit, and be at least 8 characters long.")]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
