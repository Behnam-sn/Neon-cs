using Neon.WebApi.Domain.Entities.Addresses;
using Neon.WebApi.Domain.Entities.Carts;
using Neon.WebApi.Domain.Entities.Favorites;

namespace Neon.WebApi.Domain.Entities.Users;

public sealed class Customer : User
{
    public List<Address> Addresses { get; private set; }
    public List<Cart> Carts { get; private set; }
    public List<Payment> Payments { get; private set; }
    public List<Favorite> Favorites { get; private set; }
}
