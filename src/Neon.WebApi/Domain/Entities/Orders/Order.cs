using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Users;

namespace Neon.WebApi.Domain.Entities.Orders;

public sealed class Order : Entity
{
    public List<OrderItem> Items { get; private set; }
    public Customer Owner { get; private set; }
}
