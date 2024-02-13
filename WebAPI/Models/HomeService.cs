using WebAPI.Classes.DTO;

namespace WebAPI.Classes;

public class HomeService : IHomeService
{
    private readonly IProductRepo _context;

    public HomeService(IProductRepo context)
    {
        _context = context;
    }
    public HomeDTO Get()
    {
        HomeDTO home = new();
        Campaigne campaigne1 = new Campaigne("Campaigne 1");
        Campaigne campaigne2 = new Campaigne("Campaigne 2");
        Campaigne campaigne3 = new Campaigne("Campaigne 3");
        Campaigne campaigne4 = new Campaigne("Campaigne 4");
        home.Campaignes.Add(campaigne1);
        home.Campaignes.Add(campaigne2);
        home.Campaignes.Add(campaigne3);
        home.Campaignes.Add(campaigne4);
        home.Products.Add(_context.GetProductById(4));
        home.Products.Add(_context.GetProductById(8));
        return home;
    }
}