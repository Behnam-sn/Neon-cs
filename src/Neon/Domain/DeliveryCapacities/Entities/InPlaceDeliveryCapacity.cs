using Neon.Domain.Branches.Entities;

namespace Neon.Domain.DeliveryCapacities.Entities;

public sealed class InPlaceDeliveryCapacity : DeliveryCapacity
{
    public Branch Branch { get; }
}