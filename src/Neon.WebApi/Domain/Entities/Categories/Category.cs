using Neon.WebApi.Domain.Abstractions;

namespace Neon.WebApi.Domain.Entities.Categories;

public sealed class Category : Entity
{
    public string Title { get; private set; }
    public Category? Parent { get; private set; }
    public List<CategoryField> Fields { get; private set; }
}
