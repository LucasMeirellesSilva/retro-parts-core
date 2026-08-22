using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleVersionYearConfiguration : IEntityTypeConfiguration<MotorcycleVersionYear>
{
    public void Configure(EntityTypeBuilder<MotorcycleVersionYear> builder)
    {
        builder.ToTable("motorcycle_version_years");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Year)
            .IsRequired();
        
        builder.HasIndex(x => new { x.Year, x.VersionId})
            .IsUnique();

        builder.HasOne(x => x.Version)
            .WithMany(x => x.Years)
            .HasForeignKey(x => x.VersionId);
    }
}