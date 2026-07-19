namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleVersionYear
{
    public int Id { get; private set; }

    public int Year { get; set; }

    public int VersionId { get; set; }

    public MotorcycleVersion Version { get; set; } = null!;

    public ICollection<ListingCompatibility> ListingCompatibilities { get; set; } = [];
}