using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class CartItem : Entity
{
    public ShopProduct ShopProductAssignment { get; }
    public long Quantity { get; }
}
