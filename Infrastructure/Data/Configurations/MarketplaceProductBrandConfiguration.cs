using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceProductBrandConfiguration : IEntityTypeConfiguration<MarketplaceProductBrand>
{
    public void Configure(EntityTypeBuilder<MarketplaceProductBrand> builder)
    {
        builder.ToTable("marketplace_product_brands");

        builder.HasKey(x => new
        {
            x.ProductBrandId,
            x.MarketplaceId
        });

        builder.Property(x => x.ExternalId)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasOne(x => x.ProductBrand)
            .WithMany(x => x.MarketplaceProductBrands)
            .HasForeignKey(x => x.ProductBrandId);

        builder.HasOne(x => x.Marketplace)
            .WithMany(x => x.ProductBrands)
            .HasForeignKey(x => x.MarketplaceId);
    }
}