using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class AssignedPartConfiguration : IEntityTypeConfiguration<AssignedPart>
{
    public void Configure(EntityTypeBuilder<AssignedPart> builder)
    {
        builder.ToTable("AssignedParts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UnitPrice).HasPrecision(10, 2);
        builder.Property(x => x.TotalPrice).HasPrecision(10, 2);

        builder.HasIndex(x => x.MaintenanceId);

        builder.HasOne(x => x.Maintenance)
            .WithMany(x => x.AssignedParts)
            .HasForeignKey(x => x.MaintenanceId);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.AssignedParts)
            .HasForeignKey(x => x.ProductId);
    }
}

