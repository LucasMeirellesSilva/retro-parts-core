namespace RetroPecasAPI.Domain.Entities;

public sealed class ListingImage
{
    public int Id { get; private set; }

    public int ListingId { get; set; }

    public required string Url { get; set; }

    public int Position { get; set; }

    public required Listing Listing { get; set; }
}