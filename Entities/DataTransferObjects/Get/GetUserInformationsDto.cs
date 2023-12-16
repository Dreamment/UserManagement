namespace Entities.DataTransferObjects.Get
{
    public class GetUserInformationsDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public GetAddressDto Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public GetCompanyDto Company { get; set; }
    }
}
