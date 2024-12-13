using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities.Orders;

public class OrderItem : Entity
{
    public Order Order { get; set; }
}