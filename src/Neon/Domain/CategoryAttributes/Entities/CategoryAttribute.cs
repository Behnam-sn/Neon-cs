using Neon.Domain.Categories.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.Enums;

namespace Neon.Domain.CategoryAttributes.Entities;

public sealed class CategoryAttribute : Entity
{
    public string Title { get; }
    public DataTypes DataType { get; }
    public Category Category { get; }
}
