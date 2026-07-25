namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleVersion
{
    public int Id { get; private set; }

    public string? Name { get; set; }

    public int ModelId { get; set; }

    public required MotorcycleModel Model { get; set; }

    public ICollection<MotorcycleVersionYear> Years { get; set; } = [];
}