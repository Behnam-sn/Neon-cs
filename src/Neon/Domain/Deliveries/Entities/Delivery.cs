using Neon.Domain.Carts.Entities;
using Neon.Domain.Deliveries.Enums;
using Neon.Domain.DeliveryCapacities.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;

namespace Neon.Domain.Deliveries.Entities;

public abstract class Delivery : Entity
{
    public Price Cost { get; }
    public Cart Cart { get; }
    public DeliveryTypes Type { get; }
    public DeliveryCapacity DeliveryCapacity { get; }
}
