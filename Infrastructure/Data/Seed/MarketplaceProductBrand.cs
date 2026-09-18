using Microsoft.EntityFrameworkCore;

public static class MarketplaceProductBrandSeed
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MarketplaceProductBrand>().HasData(
            new MarketplaceProductBrand { Id = 1, ProductBrandId = 3, MarketplaceId = 1, ExternalId = 2786154 },
            new MarketplaceProductBrand { Id = 2, ProductBrandId = 5, MarketplaceId = 1, ExternalId = 2431718 },
            new MarketplaceProductBrand { Id = 3, ProductBrandId = 5, MarketplaceId = 2, ExternalId = 2384569 },
            new MarketplaceProductBrand { Id = 4, ProductBrandId = 9, MarketplaceId = 1, ExternalId = 276243 },
            new MarketplaceProductBrand { Id = 5, ProductBrandId = 11, MarketplaceId = 1, ExternalId = 60559 },
            new MarketplaceProductBrand { Id = 6, ProductBrandId = 14, MarketplaceId = 1, ExternalId = 12084392 },
            new MarketplaceProductBrand { Id = 7, ProductBrandId = 14, MarketplaceId = 2, ExternalId = 2426072 },
            new MarketplaceProductBrand { Id = 8, ProductBrandId = 17, MarketplaceId = 1, ExternalId = 10718678 },
            new MarketplaceProductBrand { Id = 9, ProductBrandId = 21, MarketplaceId = 1, ExternalId = 12274940 },
            new MarketplaceProductBrand { Id = 10, ProductBrandId = 25, MarketplaceId = 1, ExternalId = 11022724 },
            new MarketplaceProductBrand { Id = 11, ProductBrandId = 28, MarketplaceId = 1, ExternalId = 6351 }
        );
    }
}
