using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class CartItem : Entity
{
    public ShopProduct ShopProductAssignment { get; private set; }
    public long Quantity { get; private set; }
}
