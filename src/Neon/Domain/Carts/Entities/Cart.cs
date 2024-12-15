using Neon.Domain.Deliveries;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class Cart : Entity
{
    public Shop Shop { get; private set; }
    public List<CartItem> Items { get; private set; }
    public Customer Owner { get; private set; }
    public Delivery Delivery { get; }
}
