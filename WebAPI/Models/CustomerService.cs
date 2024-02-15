namespace WebAPI.Classes;

public class CustomerService : ICustomerService
{
    public Customer GetCurrentUser()
    {
        return new Customer();
    }
}