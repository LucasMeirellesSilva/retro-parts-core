namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryAttributeOption
{
    public int Id { get; private set; }

    public int CategoryAttributeId { get; set; }

    public required string Value { get; set; }

    public required string Label { get; set; }
    
    public CategoryAttribute CategoryAttribute { get; set; }
}