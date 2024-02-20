using Microsoft.AspNetCore.Mvc;
using WebAPI.Classes;
using WebAPI.Classes.DTO;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _service;


    public CustomerController(ICustomerService service)
    {
        _service = service;
    }
    [HttpGet]
    // GET
    public CustomerDTO Index()
    {
        CustomerDTO dto = new();

        return dto;
    }
}