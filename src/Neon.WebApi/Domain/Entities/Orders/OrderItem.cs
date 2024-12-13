using Neon.WebApi.Domain.Abstractions;

namespace Neon.WebApi.Domain.Entities.Orders;

public class OrderItem : Entity
{
    public Order Order { get; set; }
}