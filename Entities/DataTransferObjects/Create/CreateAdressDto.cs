using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Create
{
    public class CreateAdressDto
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string Suite { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [Required]
        public CreateGeoDto Geo { get; set; }
    }
}
