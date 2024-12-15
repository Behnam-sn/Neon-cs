using Neon.Domain.Orders.Enums;
using Neon.Domain.Payments.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Orders.Entities;

public sealed class Order : Entity
{
    public OrderStates State { get; }
    public List<OrderItem> Items { get; }
    public Customer Owner { get; }
    public Shop Shop { get; }
    public Payment Payment { get; }

    // Price
}
