namespace RetroPecasAPI.Domain.Entities;

public sealed class Category
{
    public int Id { get; private set; }

    public int? ParentId { get; set; }

    public required string Name { get; set; }

    public required string Slug { get; set; }

    public Category? Parent { get; set; }

    public ICollection<Category> Children { get; set; } = [];

    public ICollection<Listing> Listings { get; set; } = [];

    public ICollection<CategoryMapping> CategoryMappings { get; set; } = [];

    public ICollection<CategoryMeasurement> CategoryMeasurements { get; set; } = [];
}