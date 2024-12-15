using Neon.Domain.Categories.Enums;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class CategoryAttribute : Entity
{
    public string Title { get; }
    public CategoryAttributeDataType DataType { get; }
    public Category Category { get; }
}
