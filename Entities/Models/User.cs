using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set;}
        [EmailAddress]
        public string Email { get; set; }
        public Guid AdressId { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Url]
        public string Website { get; set; }
        public Guid CompanyId { get; set; }

        public Adress Adress { get; set; }
        public Company Company { get; set; }
    }
}
