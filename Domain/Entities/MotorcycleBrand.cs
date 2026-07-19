namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleBrand
{
    public int Id { get; private set; }

    public required string Name { get; set; }

    public required string Slug { get; set; }

    public ICollection<MotorcycleModel> Models { get; set; } = [];
}