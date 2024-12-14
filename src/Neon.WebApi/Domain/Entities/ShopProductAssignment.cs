using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Places;
using Neon.WebApi.Domain.Entities.Products;

namespace Neon.WebApi.Domain.Entities;

public sealed class ShopProductAssignment : Entity
{
    public Shop Shop { get; private set; }
    public Product Product { get; private set; }
    public decimal Price { get; private set; }
    public long Quantity { get; private set; }

    // Discount?
}
