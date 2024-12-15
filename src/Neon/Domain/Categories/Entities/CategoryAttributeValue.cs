using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class CategoryAttributeValue : Entity
{
    public string Value { get; private set; }
    public Product Product { get; private set; }
    public CategoryAttribute CategoryField { get; private set; }
}