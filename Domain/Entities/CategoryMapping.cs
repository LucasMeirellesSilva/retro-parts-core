namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryMapping
{
    public int CategoryId { get; set; }

    public int MarketplaceCategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public MarketplaceCategory MarketplaceCategory { get; set; } = null!;
}