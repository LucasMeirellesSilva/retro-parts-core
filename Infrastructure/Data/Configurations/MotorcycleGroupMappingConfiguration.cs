using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleGroupMappingConfiguration : IEntityTypeConfiguration<MotorcycleGroupMapping>
{
    public void Configure(EntityTypeBuilder<MotorcycleGroupMapping> builder)
    {
        builder.ToTable("motorcycle_group_mapping");

        builder.HasKey(x => new { x.MotorcycleYearId, x.MotorcycleGroupId });
    }
}