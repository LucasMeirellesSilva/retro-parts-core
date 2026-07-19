using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleVersionConfiguration : IEntityTypeConfiguration<MotorcycleVersion>
{
    public void Configure(EntityTypeBuilder<MotorcycleVersion> builder)
    {
        builder.ToTable("motorcycle_versions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(255);

        builder.HasIndex(x => new
        {
            x.Name,
            x.ModelId
        }).IsUnique();

        builder.HasOne(x => x.Model)
            .WithMany(x => x.Versions)
            .HasForeignKey(x => x.ModelId);
    }
}