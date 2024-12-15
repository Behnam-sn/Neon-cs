using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Shops.Entities;

public sealed class ShopProduct : Entity
{
    public Shop Shop { get; }
    public Product Product { get; }
    public decimal Price { get; }
    public long Quantity { get; }

    // Discount?
}
