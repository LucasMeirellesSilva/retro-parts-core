using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryAttributeTypeConfiguration : IEntityTypeConfiguration<CategoryAttributeType> 
{
    public void Configure(EntityTypeBuilder<CategoryAttributeType> builder) {

        builder.ToTable("category_attribute_types");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Value)
            .HasMaxLength(55)
            .IsRequired()
    }
}