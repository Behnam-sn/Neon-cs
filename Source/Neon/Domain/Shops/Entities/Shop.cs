using Neon.Domain.Branches.Entities;
using Neon.Domain.DeliveryCapacities.Entities;
using Neon.Domain.Orders.Entities;
using Neon.Domain.Payments.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Entities;

namespace Neon.Domain.Shops.Entities;

public sealed class Shop : Entity
{
    public List<ShopProduct> ShopProducts { get; }
    public List<Branch> Branches { get; }
    public List<DeliveryCapacity> DeliveryCapacities { get; }
    public List<Order> Orders { get; }
    public List<Payment> Payments { get; } // ?
}