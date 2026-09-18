namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryAttribute
{
    public int Id { get; private set; }

    public int CategoryId { get; set; }

    public int AttributeTypeId { get; set; }

    public required string Key { get; set; }

    public required string Label { get; set; }

    public required bool Required { get; set; }

    public required int DisplayOrder { get; set;}

    public Category Category { get; set; }
    
    public CategoryAttributeType CategoryAttributeType { get; set; }
}