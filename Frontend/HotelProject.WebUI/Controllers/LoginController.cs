using DataAccessLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class LoginController : Controller
{
    private readonly SignInManager<AppUser> _manager;

    public LoginController(SignInManager<AppUser> manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(LoginUserDto userDto)
    {
        if (ModelState.IsValid)
        {
            var appUser = await _manager.PasswordSignInAsync(userDto.Username, userDto.Password, false, false);
            if (appUser.Succeeded)
            {
                RedirectToAction("Index", "Staff");
            }
        }
        return View();
    }
}