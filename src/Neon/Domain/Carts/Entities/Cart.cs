using Neon.Domain.Deliveries;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class Cart : Entity
{
    public Shop Shop { get; }
    public List<CartItem> Items { get; }
    public Customer Owner { get; }
    public Delivery Delivery { get; }
}
