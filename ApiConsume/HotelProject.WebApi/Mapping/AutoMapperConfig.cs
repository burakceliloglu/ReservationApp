using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Room, AddRoomDto>();
        CreateMap<AddRoomDto, Room>();

        CreateMap<UpdateRoomDto, Room>().ReverseMap();
    }
}

