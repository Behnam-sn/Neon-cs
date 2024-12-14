using Neon.WebApi.Domain.Entities.Places;

namespace Neon.WebApi.Domain.Entities.DeliveryCapacities;

public sealed class InPlaceDeliveryCapacity : DeliveryCapacity
{
    public Branch Branch { get; }
}