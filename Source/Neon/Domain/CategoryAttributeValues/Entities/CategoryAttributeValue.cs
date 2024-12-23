using Neon.Domain.CategoryAttributes.Entities;
using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.CategoryAttributeValues.Entities;

public sealed class CategoryAttributeValue : Entity
{
    public string Value { get; }
    public Product Product { get; }
    public CategoryAttribute CategoryField { get; }
}