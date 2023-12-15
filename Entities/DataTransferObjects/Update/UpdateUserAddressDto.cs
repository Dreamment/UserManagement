using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateUserAddressDto
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string Suite { get; set;}
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }
    }
}
