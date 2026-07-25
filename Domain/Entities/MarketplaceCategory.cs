namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceCategory
{
    public int Id { get; private set; }

    public int? ParentId { get; set; }

    public int MarketplaceId { get; set; }

    public required string ExternalId { get; set; }

    public required string Name { get; set; }

    public required Marketplace Marketplace { get; set; }

    public MarketplaceCategory? Parent { get; set; }

    public ICollection<MarketplaceCategory> Children { get; set; } = [];

    public ICollection<CategoryMapping> CategoryMappings { get; set; } = [];
}