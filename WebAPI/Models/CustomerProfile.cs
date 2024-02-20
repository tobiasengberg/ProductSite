namespace WebAPI.Classes;

public class CustomerProfile
{
    public int Id { get; set; }
    public List<Order> Orders { get; set; }
    public Account Account { get; set; }
    public List<Invoice> Invoices { get; set; }
    public string PaymentOptions { get; set; }
}