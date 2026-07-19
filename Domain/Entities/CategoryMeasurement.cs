namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryMeasurement
{
    public int CategoryId { get; set; }

    public int MeasurementId { get; set; }

    public Category Category { get; set; } = null!;

    public Measurement Measurement { get; set; } = null!;
}