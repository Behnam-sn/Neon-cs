using Neon.WebApi.Domain.Entities.DeliveryCapacities;

namespace Neon.WebApi.Domain.Entities.Places;

public sealed class Shop : Place
{
    public List<ShopProductAssignment> ShopProductAssignments { get; }
    public List<Branch> Branches { get; }
    public List<DeliveryCapacity> DeliveryCapacities { get; }
}