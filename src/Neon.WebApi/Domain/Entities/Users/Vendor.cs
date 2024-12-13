namespace Neon.WebApi.Domain.Entities.Users;

public sealed class Vendor : User
{
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
}