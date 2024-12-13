using Neon.WebApi.Domain.Abstractions;

namespace Neon.WebApi.Domain.Entities.Categories;

public sealed class CategoryField : Entity
{
    public string Title { get; private set; }
    public object Type { get; private set; }
    public Category Category { get; private set; }
}
