namespace WebAPI.Classes;

public interface IProductRepo
{
    Product Create(Product product);
    List<Product> ReadAll();
    List<Product> ReadAllByCategory(string category);
    Product GetProductById(int id);
    Product Read(int id);
    Product Update(Product product);
    void Delete(Product product);
}