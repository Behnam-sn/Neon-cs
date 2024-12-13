using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Categories;

namespace Neon.Domain.Entities.Products;

public sealed class Product : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public List<CategoryValue> CategoryValues { get; private set; }
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}
