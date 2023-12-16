using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Suite { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [AllowNull]
        [ForeignKey("Geo")]
        public Guid? GeoId { get; set; }

        public Geo? Geo { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}