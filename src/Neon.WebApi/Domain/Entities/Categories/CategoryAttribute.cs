using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Enums.Categories;

namespace Neon.WebApi.Domain.Entities.Categories;

public sealed class CategoryAttribute : Entity
{
    public string Title { get; private set; }
    public CategoryAttributeDataType DataType { get; private set; }
    public Category Category { get; private set; }
}
