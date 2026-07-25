using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
{
    public void Configure(EntityTypeBuilder<ProductBrand> builder)
    {
        builder.ToTable("product_brands");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(55)
            .IsRequired();

        builder.Property(x => x.Slug)
            .HasMaxLength(55)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }
}