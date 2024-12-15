using Neon.Domain.Addresses.Entities;
using Neon.Domain.Carts.Entities;
using Neon.Domain.Favorites;
using Neon.Domain.Payments.Entities;
using Neon.Domain.Reviews.Entities;

namespace Neon.Domain.Users.Entities;

public sealed class Customer : User
{
    public List<Address> Addresses { get; private set; }
    public List<Cart> Carts { get; private set; }
    public List<Payment> Payments { get; private set; }
    public List<Favorite> Favorites { get; private set; }
    public List<Review> Reviews { get; private set; }
}
