using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Places;
using Neon.WebApi.Domain.Enums.DeliveryCapacities;

namespace Neon.WebApi.Domain.Entities.DeliveryCapacities;

public abstract class DeliveryCapacity : Entity
{
    public DateOnly Date { get; }
    public TimeOnly From { get; }
    public TimeOnly To { get; }
    public int Capacity { get; }
    public DeliveryTypes Type { get; }
    public Shop Shop { get; }
}
