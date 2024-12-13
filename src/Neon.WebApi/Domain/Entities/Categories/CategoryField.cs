using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities.Categories;

public sealed class CategoryField : Entity
{
    public string Title { get; private set; }
    public object Type { get; private set; }
    public Category Category { get; private set; }
}
