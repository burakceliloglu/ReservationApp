using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto;

public class UpdateRoomDto
{
    public int RoomID { get; set; }
    
    [Required(ErrorMessage = "Lütfen oda numarısı giriniz.")]
    public string RoomNumber { get; set; }
    
    [Required(ErrorMessage = "Lütfen oda görselini giriniz.")]
    public string RoomCoverImage { get; set; }
    
    [Required(ErrorMessage = "Lütfen ücreti giriniz.")]
    public int Price { get; set; }
    
    [Required(ErrorMessage = "Lütfen başlık giriniz.")]
    [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter girişi yapınız.")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
    public string BedCount { get; set; }
    
    [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
    public string BathCount { get; set; }
    
    [Required(ErrorMessage = "Lütfen açıklamayı giriniz.")]
    public string Description { get; set; }
    
    public string Wifi { get; set; }
}

