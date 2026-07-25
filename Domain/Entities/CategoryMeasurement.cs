namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryMeasurement
{
    public int CategoryId { get; set; }

    public int MeasurementId { get; set; }

    public required Category Category { get; set; }

    public required Measurement Measurement { get; set; }
}