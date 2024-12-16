using Neon.Domain.ProductAttributeValues.Entities;
using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Enums;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.ShopProducts.Entities;

public sealed class ShopProduct : Entity
{
    public Shop Shop { get; }
    public Product Product { get; }
    public decimal Price { get; }
    public long Quantity { get; }
    public ShopProductStates State { get; }
    public List<ProductAttributeValue> ProductAttributeValues { get; }

    // Discount?
}
