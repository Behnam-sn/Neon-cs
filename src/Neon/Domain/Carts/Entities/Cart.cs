using Neon.Domain.Carts.Enums;
using Neon.Domain.Deliveries;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Carts.Entities;

public sealed class Cart : Entity
{
    public CartStates State { get; }
    public Shop Shop { get; }
    public Customer Owner { get; }
    public Delivery Delivery { get; }
    public List<CartItem> Items { get; }
}
