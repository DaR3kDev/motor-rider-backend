using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using motor_rider_backend.Domain.Entities;

namespace motor_rider_backend.Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.DocumentNumber).HasMaxLength(20).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(75).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(75).IsRequired();
        builder.Property(x => x.Phone).HasMaxLength(45);
        builder.Property(x => x.Email).HasMaxLength(100);

        builder.HasIndex(x => new { x.DocumentNumber, x.Email }).IsUnique();

        builder.HasOne(x => x.DocumentType)
            .WithMany(x => x.Clients)
            .HasForeignKey(x => x.DocumentTypeId);
    }
}

