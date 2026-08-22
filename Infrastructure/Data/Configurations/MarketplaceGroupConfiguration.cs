using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MotorcycleGroupConfiguration : IEntityTypeConfiguration<MotorcycleGroup>
{
    public void Configure(EntityTypeBuilder<MotorcycleGroup> builder)
    {
        builder.ToTable("motorcycle_group");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }
}