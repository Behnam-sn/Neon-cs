using Neon.Domain.Addresses.Entities;
using Neon.Domain.Carts.Entities;
using Neon.Domain.DeliveryCapacities.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;

namespace Neon.Domain.Deliveries;

public sealed class Delivery : Entity
{
    public Address Address { get; }
    public Price Cost { get; }
    public Cart Cart { get; }
    public DeliveryCapacity DeliveryCapacity { get; }
}