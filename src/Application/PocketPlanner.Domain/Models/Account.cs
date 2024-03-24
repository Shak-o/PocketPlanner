
namespace PocketPlanner.Domain.Models;

public class Account
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required byte[] Salt { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime ValidTill { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
}