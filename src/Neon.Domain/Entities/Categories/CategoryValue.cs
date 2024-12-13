using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities.Categories;

public sealed class CategoryValue : Entity
{
    public string Value { get; private set; }
    public Product Product { get; private set; }
    public CategoryField CategoryField { get; private set; }
}