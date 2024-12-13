namespace Neon.Domain.Entities.Places;

public sealed class Shop : Place
{
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
    public List<Branch> Branches { get; private set; }
}