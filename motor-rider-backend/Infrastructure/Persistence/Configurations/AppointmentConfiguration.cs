using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.ToTable("Appointments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description).HasMaxLength(500);

        builder.HasIndex(x => x.DateTime);

        builder.HasOne(x => x.Workshop).WithMany(x => x.Appointments).HasForeignKey(x => x.WorkshopId);
        builder.HasOne(x => x.User).WithMany(x => x.Appointments).HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.Motorcycle).WithMany(x => x.Appointments).HasForeignKey(x => x.MotorcycleId);
        builder.HasOne(x => x.Client).WithMany(x => x.Appointments).HasForeignKey(x => x.ClientId);
    }
}
