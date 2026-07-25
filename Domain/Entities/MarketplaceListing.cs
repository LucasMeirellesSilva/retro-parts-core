namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceListing
{
    public int ListingId { get; set; }

    public int MarketplaceId { get; set; }

    public required string Url { get; set; }

    public required string ExternalId { get; set; }

    public required decimal Price { get; set; }

    public int? InstallmentCount { get; set; }

    public decimal? InstallmentValue { get; set; }

    public decimal? InstallmentTotal { get; set; }

    public required int MarketplaceFeePercent { get; set; }

    public required decimal ShippingCost { get; set; }

    public required DateTime LastSync { get; set; }

    public required Listing Listing { get; set; }

    public required Marketplace Marketplace { get; set; }
}