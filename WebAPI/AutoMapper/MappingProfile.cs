using AutoMapper;
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
            CreateMap<UpdateUserAddressDto, Adress>();
            CreateMap<UpdateUserCompanyDto, Company>();
            CreateMap<UpdateUserInformationsDto, User>();
        }
    }
}
