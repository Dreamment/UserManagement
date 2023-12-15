using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserWebSiteDto
    {
        [Required]
        [Url]
        public string Website { get; set; }
    }
}
