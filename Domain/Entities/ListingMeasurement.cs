namespace RetroPecasAPI.Domain.Entities;

public sealed class ListingMeasurement
{
    public int ListingId { get; set; }

    public int MeasurementId { get; set; }

    public required Listing Listing { get; set; }

    public required Measurement Measurement { get; set; }
}