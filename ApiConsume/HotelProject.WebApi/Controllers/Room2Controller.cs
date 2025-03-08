using AutoMapper;
using BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelProject.WebApi.Controllers;

public class Room2Controller : Controller
{
    private readonly IRoomService _roomService;
    private readonly IMapper _mapper;

    public Room2Controller(IRoomService roomService, IMapper mapper)
    {
        _roomService = roomService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var values = _roomService.TGetList();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult AddRoom(AddRoomDto roomDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var values = _mapper.Map<Room>(roomDto);
        _roomService.TInsert(values);
        return Ok();
    }
    
    [HttpPut]
    public IActionResult UpdateRoom(UpdateRoomDto roomDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var values = _mapper.Map<Room>(roomDto);
        _roomService.TUpdate(values);
        return Ok();
    }
}