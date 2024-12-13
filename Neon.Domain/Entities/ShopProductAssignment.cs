using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Places;

namespace Neon.Domain.Entities;

public sealed class ShopProductAssignment : Entity
{
    public Shop Shop { get; private set; }
    public Product Product { get; private set; }
    public decimal Price { get; private set; }
    public long Quantity { get; private set; }
}
