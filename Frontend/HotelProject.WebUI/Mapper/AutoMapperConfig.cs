using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapper;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<UpdateServiceDto, Service>().ReverseMap();
        CreateMap<CreateServiceDto, Service>().ReverseMap();
        CreateMap<ResultServiceDto, Service>().ReverseMap();
    }
}