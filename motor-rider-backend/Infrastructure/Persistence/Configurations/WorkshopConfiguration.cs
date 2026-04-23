using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class WorkshopConfiguration : IEntityTypeConfiguration<Workshop>
{
    public void Configure(EntityTypeBuilder<Workshop> builder)
    {
        builder.ToTable("Workshops");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(75).IsRequired();

        builder.HasOne(x => x.Branch)
            .WithMany(x => x.Workshops)
            .HasForeignKey(x => x.BranchId);
    }
}
