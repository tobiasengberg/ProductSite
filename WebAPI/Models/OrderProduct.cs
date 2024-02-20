namespace WebAPI.Classes;

public class OrderProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public OrderProduct()
    {
        
    }
    public OrderProduct(Product product)
    {
        Name = product.Name;
        Description = product.Description;
        Price = product.Price;
        Category = product.Category;
    }
}