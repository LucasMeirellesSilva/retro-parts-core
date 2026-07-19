using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ListingCompatibilityConfiguration : IEntityTypeConfiguration<ListingCompatibility>
{
    public void Configure(EntityTypeBuilder<ListingCompatibility> builder)
    {
        builder.ToTable("listing_compatibility");

        builder.HasKey(x => new
        {
            x.MotorcycleYearId,
            x.ListingId
        });

        builder.HasOne(x => x.MotorcycleYear)
            .WithMany(x => x.ListingCompatibilities)
            .HasForeignKey(x => x.MotorcycleYearId);

        builder.HasOne(x => x.Listing)
            .WithMany(x => x.ListingCompatibilities)
            .HasForeignKey(x => x.ListingId);
    }
}