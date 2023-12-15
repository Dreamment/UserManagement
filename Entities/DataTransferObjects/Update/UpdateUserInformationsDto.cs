using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserInformationsDto
    {
        public string Name { get; set; }
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string Website { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public UpdateUserAddressDto UpdateUserAddressDto{ get; set; }
        public UpdateUserCompanyDto UpdateUserCompanyDto { get; set; }
    }
}
