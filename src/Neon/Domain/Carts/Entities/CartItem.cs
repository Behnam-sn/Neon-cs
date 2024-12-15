using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class CartItem : Entity
{
    public long Quantity { get; }
    public ShopProduct ShopProduct { get; }
    public Cart Cart { get; }
}
