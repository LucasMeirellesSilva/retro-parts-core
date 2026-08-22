using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleBrandConfiguration : IEntityTypeConfiguration<MotorcycleBrand>
{
    public void Configure(EntityTypeBuilder<MotorcycleBrand> builder)
    {
        builder.ToTable("motorcycle_brands");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(55)
            .IsRequired();
        
        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.Property(x => x.Slug)
            .HasMaxLength(55)
            .IsRequired();

        builder.HasIndex(x => x.Slug)
            .IsUnique();
    }
}