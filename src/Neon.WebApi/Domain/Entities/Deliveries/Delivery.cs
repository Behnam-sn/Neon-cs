using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Addresses;
using Neon.WebApi.Domain.Entities.Carts;
using Neon.WebApi.Domain.Entities.DeliveryCapacities;
using Neon.WebApi.Domain.ValueObjects;

namespace Neon.WebApi.Domain.Entities.Deliveries;

public sealed class Delivery : Entity
{
    public Address Address { get; }
    public Price Cost { get; }
    public Cart Cart { get; }
    public DeliveryCapacity DeliveryCapacity { get; }
}