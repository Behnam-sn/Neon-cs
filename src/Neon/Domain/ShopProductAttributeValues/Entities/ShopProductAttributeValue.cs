using Neon.Domain.ProductAttributeValues.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Entities;

namespace Neon.Domain.ShopProductAttributeValues.Entities;

public sealed class ShopProductAttributeValue : Entity
{
    public Guid ProductAttributeValueId { get; }
    public Guid ShopProductId { get; }

    // Navigations
    public ProductAttributeValue ProductAttributeValue { get; }
    public ShopProduct ShopProduct { get; }
}