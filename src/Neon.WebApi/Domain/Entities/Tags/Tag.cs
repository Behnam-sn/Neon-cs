using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Products;

namespace Neon.WebApi.Domain.Entities.Tags;

public sealed class Tag : Entity
{
    public string Title { get; private set; }
    public List<Product> Products { get; private set; }
}