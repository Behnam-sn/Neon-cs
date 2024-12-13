using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Products;

namespace Neon.Domain.Entities.Categories;

public sealed class CategoryValue : Entity
{
    public string Value { get; private set; }
    public Product Product { get; private set; }
    public CategoryField CategoryField { get; private set; }
}