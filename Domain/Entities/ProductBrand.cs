namespace RetroPecasAPI.Domain.Entities;

public sealed class ProductBrand
{
    public int Id { get; private set; }

    public required string Name { get; set; }

    public required string Slug { get; set; }

    public ICollection<Listing> Listings { get; set; } = [];

    public ICollection<MarketplaceProductBrand> MarketplaceProductBrands { get; set; } = [];
}