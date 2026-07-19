using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MeasurementTypeConfiguration : IEntityTypeConfiguration<MeasurementType>
{
    public void Configure(EntityTypeBuilder<MeasurementType> builder)
    {
        builder.ToTable("measurement_types");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Type)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasIndex(x => x.Type)
            .IsUnique();
    }
}