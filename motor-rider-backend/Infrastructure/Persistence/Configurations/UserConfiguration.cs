using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.DocumentNumber).HasMaxLength(20).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(75).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(75).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Password).HasMaxLength(255).IsRequired();

        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasIndex(x => new { x.DocumentNumber, x.Email }).IsUnique();

        builder.Property(x => x.Gender).HasConversion<string>();
        builder.Property(x => x.Role).HasConversion<string>();
        builder.Property(x => x.Status).HasConversion<string>();

        builder.HasOne(x => x.DocumentType)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.DocumentTypeId);

        builder.HasOne(x => x.Municipality)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.MunicipalityId);
    }
}