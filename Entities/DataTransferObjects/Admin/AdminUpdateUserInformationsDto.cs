using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Admin
{
    public class AdminUpdateUserInformationsDto
    {
        public string? UserName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z0-9!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]{8,}$",
            ErrorMessage = "Password must contain at least 1 lowercase letter, 1 uppercase letter, 1 digit, and be at least 8 characters long.")]
        public string? Password { get; set; }
        [Url]
        public string? Website { get; set; }
        public AdminUpdateAddressDto? Address { get; set; }
        public AdminUpdateCompanyDto? Company { get; set; }
    }
}
