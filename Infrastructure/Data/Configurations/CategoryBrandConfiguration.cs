using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryBrandConfiguration : IEntityTypeConfiguration<CategoryBrand>
{
    public void Configure(EntityTypeBuilder<CategoryBrand> builder)
    {
        builder.HasKey(bc => new { bc.CategoryId, bc.BrandId });

        builder.HasOne(bc => bc.Brand)
            .WithMany(b => b.CategoryBrand)
            .HasForeignKey(bc => bc.BrandId);

        builder.HasOne(bc => bc.Category)
            .WithMany(c => c.CategoryBrand)
            .HasForeignKey(bc => bc.CategoryId);

        builder.HasData(
            new CategoryBrand { BrandId = 1, CategoryId = 1 },
            new CategoryBrand { BrandId = 6, CategoryId = 1 },
            new CategoryBrand { BrandId = 7, CategoryId = 1 },
            new CategoryBrand { BrandId = 8, CategoryId = 1 },
            new CategoryBrand { BrandId = 9, CategoryId = 1 },
            new CategoryBrand { BrandId = 10, CategoryId = 1 },
            new CategoryBrand { BrandId = 11, CategoryId = 1 },
            new CategoryBrand { BrandId = 12, CategoryId = 1 },
            new CategoryBrand { BrandId = 13, CategoryId = 1 },
            new CategoryBrand { BrandId = 14, CategoryId = 1 },
            new CategoryBrand { BrandId = 15, CategoryId = 1 },
            new CategoryBrand { BrandId = 16, CategoryId = 1 },
            new CategoryBrand { BrandId = 17, CategoryId = 1 },
            new CategoryBrand { BrandId = 18, CategoryId = 2 },
            new CategoryBrand { BrandId = 19, CategoryId = 1 },
            new CategoryBrand { BrandId = 19, CategoryId = 2 },
            new CategoryBrand { BrandId = 19, CategoryId = 3 },
            new CategoryBrand { BrandId = 19, CategoryId = 4 },
            new CategoryBrand { BrandId = 19, CategoryId = 5 },
            new CategoryBrand { BrandId = 19, CategoryId = 6 },
            new CategoryBrand { BrandId = 19, CategoryId = 7 },
            new CategoryBrand { BrandId = 19, CategoryId = 8 },
            new CategoryBrand { BrandId = 19, CategoryId = 9 },
            new CategoryBrand { BrandId = 19, CategoryId = 10 },
            new CategoryBrand { BrandId = 20, CategoryId = 3 },
            new CategoryBrand { BrandId = 21, CategoryId = 8 },
            new CategoryBrand { BrandId = 22, CategoryId = 7 },
            new CategoryBrand { BrandId = 23, CategoryId = 9 }
        );
    }
}
