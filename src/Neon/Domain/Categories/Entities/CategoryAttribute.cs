using Neon.Domain.Categories.Enums;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Categories.Entities;

public sealed class CategoryAttribute : Entity
{
    public string Title { get; private set; }
    public CategoryAttributeDataType DataType { get; private set; }
    public Category Category { get; private set; }
}
