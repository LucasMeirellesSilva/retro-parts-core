using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleModelConfiguration : IEntityTypeConfiguration<MotorcycleModel>
{
    public void Configure(EntityTypeBuilder<MotorcycleModel> builder)
    {
        builder.ToTable("motorcycle_models");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(55)
            .IsRequired();

        builder.HasIndex(x => new { x.Name, x.BrandId })
            .IsUnique();

        builder.HasOne(x => x.Brand)
            .WithMany(x => x.Models)
            .HasForeignKey(x => x.BrandId);
    }
}