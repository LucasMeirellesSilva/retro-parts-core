namespace RetroPecasAPI.Domain.Entities;

public sealed class ListingCompatibility
{
    public int MotorcycleYearId { get; set; }

    public int ListingId { get; set; }

    public MotorcycleVersionYear MotorcycleYear { get; set; } = null!;

    public Listing Listing { get; set; } = null!;
}