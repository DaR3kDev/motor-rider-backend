using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.ToTable("Branches");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(75).IsRequired();
        builder.Property(x => x.Phone).HasMaxLength(45);
        builder.Property(x => x.Address).HasMaxLength(120);

        builder.HasOne(x => x.Municipality)
            .WithMany(x => x.Branches)
            .HasForeignKey(x => x.MunicipalityId);
    }
}

