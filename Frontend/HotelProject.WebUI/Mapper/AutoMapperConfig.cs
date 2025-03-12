using AutoMapper;
using DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapper;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<UpdateServiceDto, Service>().ReverseMap();
        CreateMap<CreateServiceDto, Service>().ReverseMap();
        CreateMap<ResultServiceDto, Service>().ReverseMap();
        CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
        CreateMap<LoginUserDto, AppUser>().ReverseMap();
    }
}