namespace RetroPecasAPI.Domain.Entities;

public sealed class Measurement
{
    public int Id { get; private set; }

    public decimal Size { get; set; }

    public int MeasurementTypeId { get; set; }

    public required MeasurementType MeasurementType { get; set; }

    public ICollection<CategoryMeasurement> CategoryMeasurements { get; set; } = [];

    public ICollection<ListingMeasurement> ListingMeasurements { get; set; } = [];
}