namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleVersion
{
    public int Id { get; private set; }

    public string? Name { get; set; }

    public int ModelId { get; set; }

    public MotorcycleModel Model { get; set; } = null!;

    public ICollection<MotorcycleVersionYear> Years { get; set; } = [];
}