using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Categories;
using Neon.Domain.Entities.Tags;

namespace Neon.Domain.Entities.Products;

public sealed class Product : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public List<CategoryValue> CategoryValues { get; private set; }
    public List<Tag> Tags { get; private set; }
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}
