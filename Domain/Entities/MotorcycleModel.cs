namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleModel
{
    public int Id { get; private set; }

    public required string Name { get; set; }

    public int BrandId { get; set; }

    public required MotorcycleBrand Brand { get; set; }

    public ICollection<MotorcycleVersion> Versions { get; set; } = [];
}