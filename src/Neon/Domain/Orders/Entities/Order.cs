using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Orders.Entities;

public sealed class Order : Entity
{
    public List<OrderItem> Items { get; private set; }
    public Customer Owner { get; private set; }
}
