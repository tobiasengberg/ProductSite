namespace WebAPI.Classes;

public class EMailPreferences
{
    public int Id { get; set; }
    public bool Campaigns { get; set; }
    public bool Shipping { get; set; }
    public bool NewsLetter { get; set; }
}