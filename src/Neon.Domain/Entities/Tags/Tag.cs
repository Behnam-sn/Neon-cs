using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Products;

namespace Neon.Domain.Entities.Tags;

public sealed class Tag : Entity
{
    public string Title { get; private set; }
    public List<Product> Products { get; private set; }
}