using Microsoft.EntityFrameworkCore;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.UseSnakeCaseNamingConvention();

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );
    }


    public DbSet<Listing> Listings => Set<Listing>();
    public DbSet<ListingLink> ListingLinks => Set<ListingLink>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<CategoryBrand> CategoryBrands => Set<CategoryBrand>();
    public DbSet<Picture> Pictures => Set<Picture>();
    public DbSet<Motorcycle> Motorcycles => Set<Motorcycle>();
}
