using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Create
{
    public class CreateGeoDto
    {
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }
    }
}
