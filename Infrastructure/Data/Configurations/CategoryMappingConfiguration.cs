using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryMappingConfiguration : IEntityTypeConfiguration<CategoryMapping>
{
    public void Configure(EntityTypeBuilder<CategoryMapping> builder)
    {
        builder.ToTable("category_mapping");

        builder.HasKey(x => new
        {
            x.CategoryId,
            x.MarketplaceCategoryId
        });

        builder.HasOne(x => x.Category)
            .WithMany(x => x.CategoryMappings)
            .HasForeignKey(x => x.CategoryId);

        builder.HasOne(x => x.MarketplaceCategory)
            .WithMany(x => x.CategoryMappings)
            .HasForeignKey(x => x.MarketplaceCategoryId);
    }
}