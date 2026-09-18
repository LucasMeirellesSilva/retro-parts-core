using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ListingMotorcycleGroupConfiguration : IEntityTypeConfiguration<ListingMotorcycleGroup>
{
    public void Configure(EntityTypeBuilder<ListingMotorcycleGroup> builder)
    {
        builder.ToTable("listing_motorcycle_group");

        builder.HasKey(x => new { x.ListingId, x.MotorcycleGroupId });
    }
}