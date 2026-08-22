using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ListingConfiguration : IEntityTypeConfiguration<Listing>
{
    public void Configure(EntityTypeBuilder<Listing> builder)
    {
        builder.ToTable("listings");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Description);

        builder.Property(x => x.OemCode);
            .HasMaxLength(32)

        builder.Property(x => x.NormalizedOemCode);
            .HasMaxLength(32)

        builder.Property(x => x.Active)
            .IsRequired();

        builder.Property(x => x.AvailableStock)
            .IsRequired();

        builder.Property(x => x.Genuine)
            .IsRequired();

        builder.Property(x => x.Used)
            .IsRequired();
        
        builder.Property(x => x.DeletedAt);

        builder.Property(x => x.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(x => x.UpdatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Listings)
            .HasForeignKey(x => x.CategoryId);

        builder.HasOne(x => x.ProductBrand)
            .WithMany(x => x.Listings)
            .HasForeignKey(x => x.ProductBrandId);

        builder.HasIndex(x => x.CategoryId);

        builder.HasIndex(x => x.ProductBrandId);

        builder.HasIndex(x => new { x.CategoryId, x.ProductBrandId })
            .HasFilter("\"active\" = TRUE");
    }
}