namespace YourProject.Domain.Entities;

public sealed class Listing
{
    public int Id { get; private set; }

    public int ProductBrandId { get; set; }

    public int CategoryId { get; set; }

    public required string Title { get; set; }

    public bool Active { get; set; }

    public int AvailableStock { get; set; }

    public string? Description { get; set; }

    public string? OemCode { get; set; }

    public bool Genuine { get; set; }

    public bool Used { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? LastSync { get; set; }

    public ProductBrand ProductBrand { get; set; } = null!;

    public Category Category { get; set; } = null!;

    public ICollection<ListingImage> ListingImages { get; set; } = [];

    public ICollection<MarketplaceListing> MarketplaceListings { get; set; } = [];

    public ICollection<ListingCompatibility> ListingCompatibilities { get; set; } = [];

    public ICollection<ListingMeasurement> ListingMeasurements { get; set; } = [];
}