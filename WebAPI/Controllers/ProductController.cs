using System.Collections;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Classes;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepo _repo;

    public ProductController(IProductRepo repo)
    {
        _repo = repo;
    }
    // GET
    [HttpGet]
    public IEnumerable<Product> Index()
    {
        return _repo.ReadAll();
    }

    // GET
    [HttpGet("{category}")]
    public IEnumerable<Product> GetProductsByCategory(string category)
    {
        return _repo.ReadAllByCategory(category);
    }
    
    [HttpGet("item/{id}")]
    public Product GetProductById(int id)
    {
        return _repo.GetProductById(id);
    }
    
    [HttpPost]
    public void AddProduct(Product product)
    {
        _repo.Create(product);
    }
}