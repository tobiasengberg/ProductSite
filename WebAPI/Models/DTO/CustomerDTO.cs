namespace WebAPI.Classes.DTO;

public class CustomerDTO
{
    public List<string> Orders { get; set; }
    public string Account { get; set; }
    public List<string> Invoices { get; set; }
    public string PaymentOptions { get; set; }
}