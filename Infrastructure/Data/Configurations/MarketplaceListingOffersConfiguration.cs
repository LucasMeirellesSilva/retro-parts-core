using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceListingOfferConfiguration : IEntityTypeConfiguration<MarketplaceListingOffer>
{
    public void Configure(EntityTypeBuilder<MarketplaceListingOffer> builder)
    {
        builder.ToTable("marketplace_listing_offers");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.MarketplaceListingId)
            .IsRequired();

        builder.Property(x => x.OriginalPrice)
            .HasColumnType("decimal(10,2)");
            .IsRequired();

        builder.Property(x => x.OfferPrice)
            .HasColumnType("decimal(10,2)");
            .IsRequired();

        builder.Property(x => x.StartsAt)
            .IsRequired();

        builder.Property(x => x.EndsAt)
            .IsRequired();
    }
}