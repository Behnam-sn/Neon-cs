using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.ProductAttributes.Entities;

public sealed class ProductAttribute : Entity
{
    public string Name { get; }
    public Product Product { get; }

    // Available Options
}
