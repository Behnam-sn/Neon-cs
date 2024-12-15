using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class CategoryAttributeValue : Entity
{
    public string Value { get; }
    public Product Product { get; }
    public CategoryAttribute CategoryField { get; }
}