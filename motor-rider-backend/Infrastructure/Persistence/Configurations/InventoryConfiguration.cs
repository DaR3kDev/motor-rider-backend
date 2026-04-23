using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable("Inventories");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Status).HasConversion<string>();

        builder.HasIndex(x => new { x.ProductId, x.BranchId });

        builder.HasOne(x => x.Product).WithMany(x => x.Inventory).HasForeignKey(x => x.ProductId);
        builder.HasOne(x => x.Branch).WithMany(x => x.Inventory).HasForeignKey(x => x.BranchId);
    }
}