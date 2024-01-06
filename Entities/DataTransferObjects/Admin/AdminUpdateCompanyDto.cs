using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Admin
{
    public class AdminUpdateCompanyDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CatchPhrase { get; set; }
        [Required]
        public string Bs { get; set; }
    }
}
