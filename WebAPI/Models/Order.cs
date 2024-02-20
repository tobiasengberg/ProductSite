namespace WebAPI.Classes;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public List<OrderProduct> Products { get; set; }
    public decimal TotalPayment { get; set; }
    public decimal VAT { get; set; }
}