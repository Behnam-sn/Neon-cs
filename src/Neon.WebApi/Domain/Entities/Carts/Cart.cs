using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Places;
using Neon.WebApi.Domain.Entities.Users;

namespace Neon.WebApi.Domain.Entities.Carts;

public sealed class Cart : Entity
{
    public Shop Shop { get; private set; }
    public List<CartItem> Items { get; private set; }
    public Customer Owner { get; private set; }

    // Shipping
}
