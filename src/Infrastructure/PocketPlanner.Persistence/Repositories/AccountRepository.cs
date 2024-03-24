using PocketPlanner.App.Interfaces;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.Persistence.Repositories;

public class AccountRepository(PocketPlannerContext context) : IAccountRepository
{
    private readonly PocketPlannerContext _context = context;

    public Task AddAsync(Account account, CancellationToken cancellationToken)
    {
        context.Add(account);
        return context.SaveChangesAsync(cancellationToken);
    }
}