using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class MotorcycleConfiguration : IEntityTypeConfiguration<Motorcycle>
{
    public void Configure(EntityTypeBuilder<Motorcycle> builder)
    {
        builder.ToTable("Motorcycles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SerialNumber).HasMaxLength(50).IsRequired();
        builder.Property(x => x.PlateNumber).HasMaxLength(20).IsRequired();

        builder.HasIndex(x => x.SerialNumber).IsUnique();
        builder.HasIndex(x => x.PlateNumber).IsUnique();

        builder.HasOne(x => x.User).WithMany(x => x.Motorcycles).HasForeignKey(x => x.UserId);
    }
}