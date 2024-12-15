using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class Category : Entity
{
    public string Title { get; private set; }
    public Category? Parent { get; private set; }
    public List<CategoryAttribute> Attributes { get; private set; }
}
