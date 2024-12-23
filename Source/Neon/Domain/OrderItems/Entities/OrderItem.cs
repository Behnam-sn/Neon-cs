using Neon.Domain.Orders.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.OrderItems.Entities;

public class OrderItem : Entity
{
    public long Quantity { get; }
    public decimal Price { get; }
    public Order Order { get; }
}