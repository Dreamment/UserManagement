using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public Guid AdressId { get; set; }
        [Url]
        public string Website { get; set; }
        public Guid CompanyId { get; set; }

        public Adress Adress { get; set; }
        public Company Company { get; set; }
    }
}
