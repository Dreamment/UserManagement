using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserCompanyDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CatchPhrase { get; set;}
        [Required]
        public string Bs { get; set; }
    }
}
