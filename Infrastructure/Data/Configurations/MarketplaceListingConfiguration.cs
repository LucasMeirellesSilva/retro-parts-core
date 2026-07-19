using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceListingConfiguration : IEntityTypeConfiguration<MarketplaceListing>
{
    public void Configure(EntityTypeBuilder<MarketplaceListing> builder)
    {
        builder.ToTable("marketplace_listings");

        builder.HasKey(x => new
        {
            x.ListingId,
            x.MarketplaceId
        });

        builder.Property(x => x.Url)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(x => x.ExternalId)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.InstallmentValue)
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.InstallmentTotal)
            .HasColumnType("decimal(10,2)");

        builder.HasIndex(x => new
        {
            x.ExternalId,
            x.MarketplaceId
        }).IsUnique();

        builder.HasOne(x => x.Listing)
            .WithMany(x => x.MarketplaceListings)
            .HasForeignKey(x => x.ListingId);

        builder.HasOne(x => x.Marketplace)
            .WithMany(x => x.Listings)
            .HasForeignKey(x => x.MarketplaceId);
    }
}