namespace RetroPecasAPI.Domain.Entities;

public sealed class MeasurementType
{
    public int Id { get; private set; }

    public required string Type { get; set; }

    public ICollection<Measurement> Measurements { get; set; } = [];
}