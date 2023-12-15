using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserEmailDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
