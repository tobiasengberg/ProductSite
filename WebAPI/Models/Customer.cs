using Microsoft.AspNetCore.Identity;

namespace WebAPI.Classes;

public class Customer : IdentityUser
{
    public CustomerProfile CustomerProfile { get; set; }
}