using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Create
{
    public class CreateCompanyDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CatchPhrase { get; set; }
        [Required]
        public string Bs { get; set; }
    }
}
