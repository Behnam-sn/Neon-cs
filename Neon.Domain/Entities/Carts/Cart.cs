using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Places;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities.Carts;

public sealed class Cart : Entity
{
    public Shop Shop { get; private set; }
    public List<CartItem> Items { get; private set; }
    public Customer Owner { get; private set; }

    // Delivery
}
