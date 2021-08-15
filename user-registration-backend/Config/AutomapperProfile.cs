using AutoMapper;
using UserRegistrationBackend.Dtos;
using UserRegistrationBackend.Models;

namespace UserRegistrationBackend.Config
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            ShouldMapProperty = info => info.GetMethod.IsPublic || info.GetMethod.IsAssembly;

            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<ContactDto, Contact>().ReverseMap();
            CreateMap<NameDto, Name>().ReverseMap();
            CreateMap<UserDto, AppUser>().ReverseMap();
        }
    }
}