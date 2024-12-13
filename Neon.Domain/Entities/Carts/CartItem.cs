using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities.Carts;

public sealed class CartItem : Entity
{
    public ShopProductAssignment ShopProductAssignment { get; private set; }
    public long Quantity { get; private set; }
}