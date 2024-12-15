using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Tags.Entities;

public sealed class Tag : Entity
{
    public string Title { get; }
    public List<Product> Products { get; }
}