using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleGroupConfiguration : IEntityTypeConfiguration<MotorcycleGroup>
{
    public void Configure(EntityTypeBuilder<MotorcycleGroup> builder)
    {
        builder.ToTable("motorcycle_groups");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(55);

        builder.Property(x => x.Code)
            .HasMaxLength(10);
    }
}
