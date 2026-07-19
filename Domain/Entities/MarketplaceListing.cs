namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceListing
{
    public int ListingId { get; set; }

    public int MarketplaceId { get; set; }

    public required string Url { get; set; }

    public required string ExternalId { get; set; }

    public decimal Price { get; set; }

    public int? InstallmentCount { get; set; }

    public decimal? InstallmentValue { get; set; }

    public decimal? InstallmentTotal { get; set; }

    public Listing Listing { get; set; } = null!;

    public Marketplace Marketplace { get; set; } = null!;
}