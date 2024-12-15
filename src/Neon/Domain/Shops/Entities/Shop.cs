using Neon.Domain.Branches.Entities;
using Neon.Domain.DeliveryCapacities.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Shops.Entities;

public sealed class Shop : Entity
{
    public List<ShopProduct> ShopProductAssignments { get; }
    public List<Branch> Branches { get; }
    public List<DeliveryCapacity> DeliveryCapacities { get; }
}