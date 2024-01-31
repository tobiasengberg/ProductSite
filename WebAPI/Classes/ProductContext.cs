using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Classes;

public class ProductContext : IdentityDbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }

}