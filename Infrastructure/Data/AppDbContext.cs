using Microsoft.EntityFrameworkCore;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<CategoryAttribute> CategoryAttributes => Set<CategoryAttribute>();
    public DbSet<CategoryAttributeOption> CategoryAttributeOptions => Set<CategoryAttributeOption>();
    public DbSet<CategoryAttributeType> CategoryAttributeTypes => Set<CategoryAttributeType>();
    public DbSet<CategoryMapping> CategoryMappings => Set<CategoryMapping>();

    public DbSet<Listing> Listings => Set<Listing>();
    public DbSet<ListingImage> ListingImages => Set<ListingImage>();
    public DbSet<ListingMotorcycleGroup> ListingMotorcycleGroups => Set<ListingMotorcycleGroup>();

    public DbSet<Marketplace> Marketplaces => Set<Marketplace>();
    public DbSet<MarketplaceCategory> MarketplaceCategories => Set<MarketplaceCategory>();
    public DbSet<MarketplaceListing> MarketplaceListings => Set<MarketplaceListing>();
    public DbSet<MarketplaceListingOffer> MarketplaceListingOffers => Set<MarketplaceListingOffer>();
    public DbSet<MarketplaceProductBrand> MarketplaceProductBrands => Set<MarketplaceProductBrand>();

    public DbSet<MotorcycleBrand> MotorcycleBrands => Set<MotorcycleBrand>();
    public DbSet<MotorcycleGroup> MotorcycleGroups => Set<MotorcycleGroup>();
    public DbSet<MotorcycleGroupCompatibility> MotorcycleGroupCompatibilities => Set<MotorcycleGroupCompatibility>();
    public DbSet<MotorcycleGroupMapping> MotorcycleGroupMappings => Set<MotorcycleGroupMapping>();
    public DbSet<MotorcycleModel> MotorcycleModels => Set<MotorcycleModel>();
    public DbSet<MotorcycleVersion> MotorcycleVersions => Set<MotorcycleVersion>();
    public DbSet<MotorcycleVersionYear> MotorcycleVersionYears => Set<MotorcycleVersionYear>();

    public DbSet<ProductBrand> ProductBrands => Set<ProductBrand>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.UseSnakeCaseNamingConvention();

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );

        modelBuilder.ConfigureSeedData();
    }
}