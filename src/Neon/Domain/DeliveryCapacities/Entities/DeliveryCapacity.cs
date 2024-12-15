using Neon.Domain.DeliveryCapacities.Enums;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.DeliveryCapacities.Entities;

public abstract class DeliveryCapacity : Entity
{
    public DeliveryTypes Type { get; }
    public DateOnly Date { get; }
    public TimeOnly From { get; }
    public TimeOnly To { get; }
    public long Capacity { get; }
    public Money Cost { get; }
    public DeliveryCapacityStates State { get; }
    public Shop Shop { get; }
}
