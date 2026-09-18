using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class CategoryAttributeOptionConfiguration : IEntityTypeConfiguration<CategoryAttributeOption> 
{
    public void Configure(EntityTypeBuilder<CategoryAttributeOption> builder) {

        builder.ToTable("category_attribute_options");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Value)
            .HasMaxLength(55)
            .IsRequired()

        builder.Property(x => x.Label)
            .HasMaxLength(55)
            .IsRequired()
    }
}