using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities.Orders;

public sealed class Order : Entity
{
    public List<OrderItem> Items { get; private set; }
    public Customer Owner { get; private set; }
}
