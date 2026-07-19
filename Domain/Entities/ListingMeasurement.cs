namespace RetroPecasAPI.Domain.Entities;

public sealed class ListingMeasurement
{
    public int ListingId { get; set; }

    public int MeasurementId { get; set; }

    public Listing Listing { get; set; } = null!;

    public Measurement Measurement { get; set; } = null!;
}