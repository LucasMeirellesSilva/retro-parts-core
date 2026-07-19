using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryMeasurementConfiguration : IEntityTypeConfiguration<CategoryMeasurement>
{
    public void Configure(EntityTypeBuilder<CategoryMeasurement> builder)
    {
        builder.ToTable("category_measurements");

        builder.HasKey(x => new
        {
            x.CategoryId,
            x.MeasurementId
        });

        builder.HasOne(x => x.Category)
            .WithMany(x => x.CategoryMeasurements)
            .HasForeignKey(x => x.CategoryId);

        builder.HasOne(x => x.Measurement)
            .WithMany(x => x.CategoryMeasurements)
            .HasForeignKey(x => x.MeasurementId);
    }
}