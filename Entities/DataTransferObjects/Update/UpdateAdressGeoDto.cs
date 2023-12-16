using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Update
{
    public class UpdateAdressGeoDto
    {
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }
    }
}
