using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class MovementConfiguration : IEntityTypeConfiguration<Movement>
{
    public void Configure(EntityTypeBuilder<Movement> builder)
    {
        builder.ToTable("Movements");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.MovementType).HasConversion<string>();

        builder.HasOne(x => x.Inventory)
            .WithMany(x => x.Movements)
            .HasForeignKey(x => x.InventoryId);
    }
}