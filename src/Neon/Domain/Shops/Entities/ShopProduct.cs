using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Shops.Entities;

public sealed class ShopProduct : Entity
{
    public Shop Shop { get; private set; }
    public Product Product { get; private set; }
    public decimal Price { get; private set; }
    public long Quantity { get; private set; }

    // Discount?
}
