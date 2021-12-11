namespace SecurityKpi.Lab3.Models;

public class Account
{
    public int Id { get; set; }
    public int Money { get; set; }
    public DateTime DeletionTime { get; set; }

    public Account(int id)
    {
        Id = id;
        Money = 1000;
        DeletionTime = DateTime.Now + TimeSpan.FromDays(30);
    }
}