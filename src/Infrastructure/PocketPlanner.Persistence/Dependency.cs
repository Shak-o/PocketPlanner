using Microsoft.Extensions.DependencyInjection;
using PocketPlanner.App.Interfaces;
using PocketPlanner.Persistence.Repositories;

namespace PocketPlanner.Persistence;

public static class Dependency
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        
        return services;
    }
}