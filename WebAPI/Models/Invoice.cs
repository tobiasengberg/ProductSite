namespace WebAPI.Classes;

public class Invoice
{
    public int Id { get; set; }
    public decimal TotalAmmount { get; set; }
    public decimal VAT { get; set; }
    public bool Paid { get; set; }
}