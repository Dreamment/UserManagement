using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserInformationsDto
    {
        [AllowNull]
        public string? Name { get; set; }
        [AllowNull]
        public string? Username { get; set; }
        [AllowNull]
        [EmailAddress]
        public string? Email { get; set; }
        [AllowNull]
        [Url]
        public string? Website { get; set; }
        [AllowNull]
        [Phone]
        public string? PhoneNumber { get; set; }
        [AllowNull]
        public UpdateUserAddressDto? UpdateUserAddressDto{ get; set; }
        [AllowNull]
        public UpdateUserCompanyDto? UpdateUserCompanyDto { get; set; }
    }
}
