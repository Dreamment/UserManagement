using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Geo
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }

        public ICollection<Address>? Addresses { get; set; }
    }
}