namespace MilkApi.Models;

public class Milk
{
    public string name { get; set; } = null!;
    public string type { get; set; } = null!;
    public int storage { get; set; }
    public Guid id { get; set; }
}