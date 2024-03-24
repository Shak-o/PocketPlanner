using MediatR;

namespace PocketPlanner.App.Commands.AccountCommands;

public class AddAccountRequestHandler : IRequestHandler<AddAccountRequest, int>
{
    public async Task<int> Handle(AddAccountRequest request, CancellationToken cancellationToken)
    {
        
        return 0;
    }
}