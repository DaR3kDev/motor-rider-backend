using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.UnitPrice)
            .HasPrecision(10, 2);

        // ENUMS
        builder.Property(x => x.ProductType).HasConversion<string>();
        builder.Property(x => x.Status).HasConversion<string>();
    }
}