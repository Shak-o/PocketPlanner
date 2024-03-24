using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.Persistence.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Salt).IsRequired().HasMaxLength(500);
        builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(6000);
        builder.Property(x => x.Username).IsRequired().HasMaxLength(50);

        builder.HasOne<User>(x => x.User);
    }
}