using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Orders.Entities;

public class OrderItem : Entity
{
    public Order Order { get; set; }
}