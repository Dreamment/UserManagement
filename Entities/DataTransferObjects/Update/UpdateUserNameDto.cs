using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserNameDto
    {
        [Required]
        public string Name { get; set; }
    }
}
