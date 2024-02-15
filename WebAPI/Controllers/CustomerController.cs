using Microsoft.AspNetCore.Mvc;
using WebAPI.Classes;
using WebAPI.Classes.DTO;

namespace WebAPI.Controllers;

public class CustomerController : Controller
{
    private readonly ICustomerService _service;


    public CustomerController(ICustomerService service)
    {
        _service = service;
    }
    // GET
    public CustomerDTO Index()
    {
        CustomerDTO dto = new();
        dto.Orders = new List<string>();
        dto.Orders.Add("Shopping Technical Stuff");
        dto.Orders.Add("More Technical Stuff");
        dto.Orders.Add("Shopping Food Stuff");
        dto.Account = "The user";
        dto.PaymentOptions = "Use Visa";
        dto.Invoices = new List<string>();
        dto.Invoices.Add("200kr");
        dto.Invoices.Add("820kr");
        return dto;
    }
}