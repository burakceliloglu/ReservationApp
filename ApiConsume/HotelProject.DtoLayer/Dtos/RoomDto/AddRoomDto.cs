using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto;

public class AddRoomDto
{
    [Required(ErrorMessage = "Lütfen oda numarısı giriniz.")]
    public string RoomNumber { get; set; }
    
    public string RoomCoverImage { get; set; }
    
    [Required(ErrorMessage = "Lütfen ücreti giriniz.")]
    public int Price { get; set; }
    
    [Required(ErrorMessage = "Lütfen başlık giriniz.")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
    public string BedCount { get; set; }
    
    [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
    public string BathCount { get; set; }
    
    public string Description { get; set; }
    
    public string Wifi { get; set; }
}


