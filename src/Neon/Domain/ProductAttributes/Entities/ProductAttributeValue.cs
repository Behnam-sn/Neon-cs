using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.ProductAttributes.Entities;

public sealed class ProductAttributeValue : Entity
{
    public string Value { get; }
    public ProductAttribute ProductAttribute { get; }
    public Shop Shop { get; }
}