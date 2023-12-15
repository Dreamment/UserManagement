using Entities.Models;

namespace Entities.DataTransferObjects.Get
{
    public class GetUserInformationsDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public Adress Adress { get; set; }
        public string Website { get; set; }
        public Company Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
