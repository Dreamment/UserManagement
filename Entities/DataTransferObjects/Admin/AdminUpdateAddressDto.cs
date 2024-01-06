using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Admin
{
    public class AdminUpdateAddressDto
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
        public AdminUpdateGeoDto Geo { get; set; }
    }
}
