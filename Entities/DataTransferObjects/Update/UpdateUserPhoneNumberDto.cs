using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserPhoneNumberDto
    {
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
