using Microsoft.EntityFrameworkCore;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.Persistence;

public class PocketPlannerContext : DbContext
{
    public PocketPlannerContext(DbContextOptions<PocketPlannerContext> options) : base(options)
    {
        
    }
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<DebitCredit> DebitCredits { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PocketPlannerContext).Assembly);
    }
}