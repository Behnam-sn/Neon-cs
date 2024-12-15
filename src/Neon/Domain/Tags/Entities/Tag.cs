using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Tags.Entities;

public sealed class Tag : Entity
{
    public string Title { get; private set; }
    public List<Product> Products { get; private set; }
}