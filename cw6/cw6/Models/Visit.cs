namespace cw6.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string Discription { get; set; }
    public float Price { get; set; }
}