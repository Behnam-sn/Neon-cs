using Neon.Domain.MeasurementUnits.Entities;
using Neon.Domain.ProductAttributeValues.Entities;
using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.ProductAttributes.Entities;

public sealed class ProductAttribute : Entity
{
    public string Name { get; }
    public Guid ProductId { get; }
    public Guid MeasurementUnitId { get; }

    // Navigations
    public Product Product { get; }
    public MeasurementUnit MeasurementUnit { get; }
    public List<ProductAttributeValue> AvaliableOptions { get; }
}
