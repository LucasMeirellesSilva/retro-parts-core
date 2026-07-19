namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceProductBrand
{
    public int ProductBrandId { get; set; }

    public int MarketplaceId { get; set; }

    public required string ExternalId { get; set; }

    public ProductBrand ProductBrand { get; set; } = null!;

    public Marketplace Marketplace { get; set; } = null!;
}