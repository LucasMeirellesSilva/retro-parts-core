using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryAttributeConfiguration : IEntityTypeConfiguration<CategoryAttribute>
{
    public void Configure(EntityTypeBuilder<CategoryAttribute> builder)
    {
        builder.ToTable("category_attributes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Key)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Label)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Required)
            .IsRequired();

        builder.Property(x => x.DisplayOrder)
            .IsRequired();

        builder.HasOne(x => x.Category)
            .WithMany(x => x.CategoryAttributes)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.AttributeType)
            .WithMany(x => x.CategoryAttributes)
            .HasForeignKey(x => x.AttributeTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}