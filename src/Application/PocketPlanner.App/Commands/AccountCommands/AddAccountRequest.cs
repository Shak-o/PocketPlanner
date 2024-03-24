using MediatR;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.App.Commands.AccountCommands;

public class AddAccountRequest : IRequest<int>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
}