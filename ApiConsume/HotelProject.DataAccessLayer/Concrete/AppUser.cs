using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Concrete;

public class AppUser : IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
}