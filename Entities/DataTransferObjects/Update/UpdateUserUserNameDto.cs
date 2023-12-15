using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserUserNameDto
    {
        [Required]
        public string UserName { get; set; }
    }
}
