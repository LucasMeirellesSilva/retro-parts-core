using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MeasurementConfiguration : IEntityTypeConfiguration<Measurement>
{
    public void Configure(EntityTypeBuilder<Measurement> builder)
    {
        builder.ToTable("measurements");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Size)
            .HasColumnType("decimal(5,2)")
            .IsRequired();

        builder.HasIndex(x => new { x.Size, x.MeasurementTypeId })
            .IsUnique();

        builder.HasOne(x => x.MeasurementType)
            .WithMany(x => x.Measurements)
            .HasForeignKey(x => x.MeasurementTypeId);
    }
}