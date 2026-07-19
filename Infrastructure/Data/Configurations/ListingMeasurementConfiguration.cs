using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ListingMeasurementConfiguration : IEntityTypeConfiguration<ListingMeasurement>
{
    public void Configure(EntityTypeBuilder<ListingMeasurement> builder)
    {
        builder.ToTable("listings_measurements");

        builder.HasKey(x => new
        {
            x.ListingId,
            x.MeasurementId
        });

        builder.HasOne(x => x.Listing)
            .WithMany(x => x.ListingMeasurements)
            .HasForeignKey(x => x.ListingId);

        builder.HasOne(x => x.Measurement)
            .WithMany(x => x.ListingMeasurements)
            .HasForeignKey(x => x.MeasurementId);
    }
}