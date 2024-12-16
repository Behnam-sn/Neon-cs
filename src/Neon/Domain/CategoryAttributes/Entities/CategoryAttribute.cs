using Neon.Domain.Categories.Entities;
using Neon.Domain.CategoryAttributes.Enums;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.CategoryAttributes.Entities;

public sealed class CategoryAttribute : Entity
{
    public string Title { get; }
    public CategoryAttributeDataType DataType { get; }
    public Category Category { get; }
}
