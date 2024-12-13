namespace Neon.WebApi.Domain.Entities.Places;

public sealed class Shop : Place
{
    public List<ShopProductAssignment> ShopProductAssignments { get; private set; }
    public List<Branch> Branches { get; private set; }
}