namespace RetroPecasAPI.Domain.Entities;

public sealed class CategoryAttributeType
{
    public int Id { get; private set; }

    public required string value { get; set; }

    public ICollection<CategoryAttribute> CategoryAttributes { get; set; }
}