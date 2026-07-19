using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroPecasAPI.Domain.Entities;

namespace RetroPecasAPI.Infrastructure.Data.Configurations;

public class MarketplaceCategoryConfiguration : IEntityTypeConfiguration<MarketplaceCategory>
{
    public void Configure(EntityTypeBuilder<MarketplaceCategory> builder)
    {
        builder.ToTable("marketplace_categories");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ExternalId)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Marketplace)
            .WithMany(x => x.Categories)
            .HasForeignKey(x => x.MarketplaceId);
    }
}