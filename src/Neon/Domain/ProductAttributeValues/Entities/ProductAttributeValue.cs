using Neon.Domain.MeasurementUnitValues.Entities;
using Neon.Domain.ProductAttributes.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.ProductAttributeValues.Entities;

public sealed class ProductAttributeValue : Entity
{
    public Guid ProductAttributeId { get; }
    public Guid MeasurementUnitValueId { get; }

    // Navigations
    public ProductAttribute ProductAttribute { get; }
    public MeasurementUnitValue MeasurementUnitValue { get; }
}