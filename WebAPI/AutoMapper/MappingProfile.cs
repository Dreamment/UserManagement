using AutoMapper;
using Entities.DataTransferObjects.Auth;
using Entities.DataTransferObjects.Create;
using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
using Entities.Models;

namespace WebAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, GetUserInformationsDto>();
            CreateMap<UpdateUserAddressDto, Address>();
            CreateMap<UpdateUserCompanyDto, Company>();
            CreateMap<UpdateUserInformationsDto, User>();
            CreateMap<Address, GetAddressDto>();
            CreateMap<Company, GetCompanyDto>();
            CreateMap<Geo, GetGeoDto>();
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<CreateAdressDto, Address>();
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<CreateGeoDto, Geo>();
        }
    }
}
