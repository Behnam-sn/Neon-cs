using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Categories;
using Neon.WebApi.Domain.Entities.Tags;

namespace Neon.WebApi.Domain.Entities.Products;

public sealed class Product : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public List<CategoryAttributeValue> CategoryAttributeValues { get; private set; }
    public List<Tag> Tags { get; private set; }
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}
