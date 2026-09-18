using Microsoft.EntityFrameworkCore;

public static class SeedExtensions
{
    public static void ConfigureSeedData(this ModelBuilder modelBuilder)
    {
        MarketplaceSeed.Configure(modelBuilder);
        ProductBrandSeed.Configure(modelBuilder);
        MotorcycleBrandSeed.Configure(modelBuilder);
        MotorcycleModelSeed.Configure(modelBuilder);
        MotorcycleVersionSeed.Configure(modelBuilder);
        CategorySeed.Configure(modelBuilder);
        MarketplaceProductBrandSeed.Configure(modelBuilder);
    }
}
