using Neon.Domain.Shops.Entities;

namespace Neon.Domain.Users.Entities;

public sealed class Vendor : User
{
    public List<ShopProduct> ShopProductAssignments { get; private set; }
}