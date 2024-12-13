using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Products;

namespace Neon.WebApi.Domain.Entities.Categories;

public sealed class CategoryValue : Entity
{
    public string Value { get; private set; }
    public Product Product { get; private set; }
    public CategoryField CategoryField { get; private set; }
}