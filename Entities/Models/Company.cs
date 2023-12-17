using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CatchPhrase { get; set; }
        [Required]
        public string Bs { get; set; }
    }
}