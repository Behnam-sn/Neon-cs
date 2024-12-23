using Neon.Domain.Cities.Entities;
using Neon.Domain.Countries.Entities;
using Neon.Domain.Provinces.Entities;
using Neon.Domain.Shared.ValueObjects;

namespace Neon.Domain.DeliveryCapacities.Entities;

public sealed class ShippingDeliveryCapacity : DeliveryCapacity
{
    public Country Country { get; }
    public Province Province { get; }
    public City City { get; }
    public Region Region { get; }
}
