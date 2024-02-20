using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Classes;

public class ProductContext : IdentityDbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Campaigne> Campaigns { get; set; }
    public DbSet<CustomerProfile> CustomerProfiles { get; set; }

}