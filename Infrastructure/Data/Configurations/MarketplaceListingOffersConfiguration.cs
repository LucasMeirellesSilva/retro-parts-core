using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceListingOfferConfiguration : IEntityTypeConfiguration<MarketplaceListingOffer>
{
    public void Configure(EntityTypeBuilder<MarketplaceListingOffer> builder)
    {
        builder.ToTable("marketplace_listing_offers");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.MarketplaceListingId)
            .IsRequired();

        builder.Property(e => e.OriginalPrice)
            .HasColumnType("decimal(10,2)");
            .IsRequired();

        builder.Property(e => e.OfferPrice)
            .HasColumnType("decimal(10,2)");
            .IsRequired();

        builder.Property(e => e.StartsAt)
            .IsRequired();

        builder.Property(e => e.EndsAt)
            .IsRequired();
    }
}