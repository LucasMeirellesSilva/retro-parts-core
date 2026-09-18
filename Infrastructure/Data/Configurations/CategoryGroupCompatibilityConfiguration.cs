using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryGroupCompatibilityConfiguration : IEntityTypeConfiguration<CategoryGroupCompatibility>
{
    public void Configure(EntityTypeBuilder<CategoryGroupCompatibility> builder)
    {
        builder.ToTable("category_group_compatibility");

        builder.HasKey(x => new { x.MotorcycleGroupId, x.CategoryId });
    }
}