using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class Category : Entity
{
    public string Title { get; }
    public Category? Parent { get; }
    public List<CategoryAttribute> Attributes { get; }
}
