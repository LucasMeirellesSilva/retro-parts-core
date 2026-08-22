using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceConfiguration : IEntityTypeConfiguration<Marketplace>
{
    public void Configure(EntityTypeBuilder<Marketplace> builder)
    {
        builder.ToTable("marketplaces");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(55)
            .IsRequired();

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }
}