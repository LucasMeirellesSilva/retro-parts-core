namespace RetroPecasAPI.Domain.Entities;

public sealed class MotorcycleVersionYear
{
    public int Id { get; private set; }

    public int Year { get; set; }

    public int VersionId { get; set; }

    public required MotorcycleVersion Version { get; set; }

    public ICollection<ListingCompatibility> ListingCompatibilities { get; set; } = [];
}