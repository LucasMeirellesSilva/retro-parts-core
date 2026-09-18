using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleGroupCompatibilityConfiguration : IEntityTypeConfiguration<MotorcycleGroupCompatibility>
{
    public void Configure(EntityTypeBuilder<MotorcycleGroupCompatibility> builder)
    {
        builder.ToTable("motorcycle_group_compatibility");

        builder.HasKey(x => new { x.MotorcycleGroupId, x.CategoryId });
    }
}