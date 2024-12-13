using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities;

public sealed class Product : Entity
{
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}
