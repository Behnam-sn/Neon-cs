using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Enums;

namespace Neon.Domain.Shops.Entities;

public sealed class ShopProduct : Entity
{
    public Shop Shop { get; }
    public Product Product { get; }
    public decimal Price { get; }
    public long Quantity { get; }
    public ShopProductStates State { get; }

    // Discount?
}
