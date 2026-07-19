namespace RetroPecasAPI.Domain.Entities;

public sealed class Marketplace
{
    public int Id { get; private set; }

    public required string Name { get; set; }

    public required string DefaultQueryUrl { get; set; }

    public ICollection<MarketplaceCategory> Categories { get; set; } = [];

    public ICollection<MarketplaceListing> Listings { get; set; } = [];

    public ICollection<MarketplaceProductBrand> ProductBrands { get; set; } = [];
}