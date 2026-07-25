namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceProductBrand
{
    public int ProductBrandId { get; set; }

    public int MarketplaceId { get; set; }

    public required string ExternalId { get; set; }

    public required ProductBrand ProductBrand { get; set; }

    public required Marketplace Marketplace { get; set; }
}