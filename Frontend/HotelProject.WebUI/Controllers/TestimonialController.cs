using System.Text;
using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class TestimonialController : Controller
{
private readonly IHttpClientFactory _httpClientFactory;

    public TestimonialController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("https://localhost:7248/api/Testimonial");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
    
    public IActionResult AddTestimonial()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddTestimonial(TestimonialViewModel viewModel)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(viewModel);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7248/api/Testimonial", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7248/api/Testimonial/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> UpdateTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync($"https://localhost:7248/api/Testimonial/{id}");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateStaffViewModel>(jsonData);
            return View(values);
        }
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> UpdateTestimonial(TestimonialViewModel model)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(model);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7248/api/Testimonial/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}