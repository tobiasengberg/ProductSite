namespace WebAPI.Classes;

public class Campaigne
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public Campaigne(string title)
    {
        Title = title;
    }
}