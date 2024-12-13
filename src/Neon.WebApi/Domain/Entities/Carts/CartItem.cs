using Neon.WebApi.Domain.Abstractions;

namespace Neon.WebApi.Domain.Entities.Carts;

public sealed class CartItem : Entity
{
    public ShopProductAssignment ShopProductAssignment { get; private set; }
    public long Quantity { get; private set; }
}
