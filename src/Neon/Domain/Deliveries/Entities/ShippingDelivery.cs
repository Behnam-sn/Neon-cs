using Neon.Domain.Addresses.Entities;

namespace Neon.Domain.Deliveries.Entities;

public sealed class ShippingDelivery : Delivery
{
    public Address Address { get; }
}