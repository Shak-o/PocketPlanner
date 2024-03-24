using PocketPlanner.Domain.Models;

namespace PocketPlanner.App.Interfaces;

public interface IAccountRepository
{
    Task AddAsync(Account account, CancellationToken cancellationToken);
}