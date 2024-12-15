using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Orders.Entities;

public class OrderItem : Entity
{
    public long Quantity { get; }
    public decimal Price { get; }
    public Order Order { get; }
}