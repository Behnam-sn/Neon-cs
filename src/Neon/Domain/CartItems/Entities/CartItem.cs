using Neon.Domain.CartItems.Enums;
using Neon.Domain.Carts.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Entities;

namespace Neon.Domain.CartItems.Entities;

public sealed class CartItem : Entity
{
    public long Quantity { get; }
    public CartItemStates State { get; }
    public ShopProduct ShopProduct { get; }
    public Cart Cart { get; }
}
