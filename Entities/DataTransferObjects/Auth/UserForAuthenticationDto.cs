using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Entities.DataTransferObjects.Auth
{
    public class UserForAuthenticationDto
    {
        [AllowNull]
        public string? Email { get; set; }
        [AllowNull]
        public string? UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
