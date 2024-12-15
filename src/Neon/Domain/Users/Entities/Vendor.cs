using Neon.Domain.ShopProducts.Entities;

namespace Neon.Domain.Users.Entities;

public sealed class Vendor : User
{
    public List<ShopProduct> ShopProducts { get; }
}