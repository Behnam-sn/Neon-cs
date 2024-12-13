using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Places;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities;

public sealed class ShopProductAssignment : Entity
{
    public Shop Shop { get; private set; }
    public Product Product { get; private set; }
    public decimal Price { get; private set; }
    public long Quantity { get; private set; }
    public Vendor Owner { get; private set; }
}
