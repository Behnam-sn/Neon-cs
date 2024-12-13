using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities;

public sealed class Product : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}
