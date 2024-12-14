using Neon.WebApi.Domain.Entities.Addresses;
using Neon.WebApi.Domain.Entities.Carts;
using Neon.WebApi.Domain.Entities.Favorites;
using Neon.WebApi.Domain.Entities.Reviews;

namespace Neon.WebApi.Domain.Entities.Users;

public sealed class Customer : User
{
    public List<Address> Addresses { get; private set; }
    public List<Cart> Carts { get; private set; }
    public List<Payment> Payments { get; private set; }
    public List<Favorite> Favorites { get; private set; }
    public List<Review> Reviews { get; private set; }
}
