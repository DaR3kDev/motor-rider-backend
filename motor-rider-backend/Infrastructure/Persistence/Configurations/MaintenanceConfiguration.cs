using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class MaintenanceConfiguration : IEntityTypeConfiguration<Maintenance>
{
    public void Configure(EntityTypeBuilder<Maintenance> builder)
    {
        builder.ToTable("Maintenances");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Cost).HasPrecision(10, 2);

        builder.HasOne(x => x.Workshop).WithMany(x => x.Maintenance).HasForeignKey(x => x.WorkshopId);
        builder.HasOne(x => x.Appointment).WithMany(x => x.Maintenance).HasForeignKey(x => x.AppointmentId);
    }
}
