namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryMapping
{
    public int CategoryId { get; set; }

    public int MarketplaceCategoryId { get; set; }

    public required Category Category { get; set; }

    public required MarketplaceCategory MarketplaceCategory { get; set; }
}