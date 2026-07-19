public sealed class Motorcycle 
{
    public int Id { get; private set; }
    public string Name { get; set; }
    
    // Foreign Key
    public int ListingId { get; set; }

    // Navigation
    public Listing Listing { get; set; } = null!;
}