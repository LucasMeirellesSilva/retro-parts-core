using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class ListingImageConfiguration : IEntityTypeConfiguration<ListingImage>
{
    public void Configure(EntityTypeBuilder<ListingImage> builder)
    {
        builder.ToTable("listing_images");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Url)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(x => x.Position)
            .IsRequired();

        builder.HasIndex(x => new
        {
            x.ListingId,
            x.Position
        }).IsUnique();

        builder.HasOne(x => x.Listing)
            .WithMany(x => x.ListingImages)
            .HasForeignKey(x => x.ListingId);
    }
}