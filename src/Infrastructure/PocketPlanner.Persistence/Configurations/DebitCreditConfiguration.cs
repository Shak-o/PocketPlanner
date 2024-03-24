using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocketPlanner.Domain.Models;

namespace PocketPlanner.Persistence.Configurations;

public class DebitCreditConfiguration : IEntityTypeConfiguration<DebitCredit>
{
    public void Configure(EntityTypeBuilder<DebitCredit> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Amount).HasPrecision(10, 5);
        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.RepeatsEvery).IsRequired(false);
        
        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}