namespace YourProject.Domain.Entities;

public sealed class Listing
{
    public int Id { get; private set; }

    public int ProductBrandId { get; set; }

    public int CategoryId { get; set; }

    public required string Title { get; set; }

    public bool Active { get; set; }

    public required int AvailableStock { get; set; }

    public string? Description { get; set; }

    public string? OemCode { get; set; }

    public string? NormalizedOemCode { get; set; }

    public required bool Genuine { get; set; }

    public bool Used { get; set; }

    public JsonDocument Attributes { get; private set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public required ProductBrand ProductBrand { get; set; }

    public required Category Category { get; set; }

    public ICollection<ListingImage> ListingImages { get; set; } = [];

    public ICollection<MarketplaceListing> MarketplaceListings { get; set; } = [];

    public ICollection<ListingCompatibility> ListingCompatibilities { get; set; } = [];
}
