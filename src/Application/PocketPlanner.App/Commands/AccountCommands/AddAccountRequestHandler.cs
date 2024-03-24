using MediatR;
using PocketPlanner.App.Helpers;
using PocketPlanner.App.Interfaces;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.App.Commands.AccountCommands;

public class AddAccountRequestHandler(IAccountRepository accountRepository) : IRequestHandler<AddAccountRequest, int>
{
    public async Task<int> Handle(AddAccountRequest request, CancellationToken cancellationToken)
    {
        var salt = PasswordHelper.GenerateSalt(255);
        var passwordHash = PasswordHelper.HashPassword(request.Password, salt, 100, 100);
        var account = new Account
        {
            Username = request.Username,
            PasswordHash = passwordHash,
            Salt = salt,
            ValidTill = DateTime.Now.AddDays(100),
            User = new User
            {
                Name = request.Name,
                Email = request.Email,
                SurName = request.LastName
            }
        };
        
        await accountRepository.AddAsync(account, cancellationToken);
        
        return account.Id;
    }
}