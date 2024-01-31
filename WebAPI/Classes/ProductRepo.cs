namespace WebAPI.Classes;

public class ProductRepo : IProductRepo
{
    private readonly ProductContext _context;

    public ProductRepo(ProductContext context)
    {
        _context = context;
    }
    public Product Create(Product product)
    {
        _context.Add(product);
        _context.SaveChanges();
        return product;
    }

    public List<Product> ReadAll()
    {
        return _context.Products.ToList();
    }

    public Product Read(int id)
    {
        throw new NotImplementedException();
    }

    public Product Update(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product product)
    {
        throw new NotImplementedException();
    }
}