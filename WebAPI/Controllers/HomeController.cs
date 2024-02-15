using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using WebAPI.Classes;
using WebAPI.Classes.DTO;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IHomeService _service;


    public HomeController(IHomeService service)
    {
        _service = service;
    }
    // GET
    [HttpGet]
    public HomeDTO Index()
    {
        return _service.Get();
    }
}