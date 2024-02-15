using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(6, 0, 0))));
builder.Services.AddIdentityApiEndpoints<Customer>()
    .AddEntityFrameworkStores<ProductContext>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/logout", async (SignInManager<Customer> signInManager,
        [FromBody]object empty) =>
    {
        if (empty != null)
        {
            await signInManager.SignOutAsync();
            return Results.Ok();
        }
        return Results.Unauthorized();
    })
    .RequireAuthorization();

app.MapIdentityApi<Customer>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();