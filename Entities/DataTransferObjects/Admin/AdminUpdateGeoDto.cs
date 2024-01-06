using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Admin
{
    public class AdminUpdateGeoDto
    {
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lng { get; set; }
    }
}
