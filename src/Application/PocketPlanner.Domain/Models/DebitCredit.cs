

namespace PocketPlanner.Domain.Models;

public class DebitCredit
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Amount { get; set; }
    public int UserId { get; set; }
    public DateTime? RepeatsAt { get; set; }
    public int IsRepeating { get; set; }
    public RepeatEvery? RepeatsEvery { get; set; }
    public PaymentType Type { get; set; }
}

public enum RepeatEvery
{
    Day,
    Month,
    Year
}

public enum PaymentType
{
    Income,
    Outcome
}