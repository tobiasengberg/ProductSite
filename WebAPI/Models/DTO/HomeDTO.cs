namespace WebAPI.Classes.DTO;

public class HomeDTO
{
    public List<Campaigne>? Campaignes { get; set; } = new();
    public List<Product>? Products { get; set; } = new();
}