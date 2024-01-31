namespace WebAPI.Classes;

public interface IProductRepo
{
    Product Create(Product product);
    List<Product> ReadAll();
    Product Read(int id);
    Product Update(Product product);
    void Delete(Product product);
}