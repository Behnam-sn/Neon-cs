using Neon.Domain.Addresses.Entities;
using Neon.Domain.Carts.Entities;
using Neon.Domain.Favorites.Entities;
using Neon.Domain.Payments.Entities;
using Neon.Domain.Reviews.Entities;

namespace Neon.Domain.Users.Entities;

public sealed class Customer : User
{
    public List<Address> Addresses { get; }
    public List<Cart> Carts { get; }
    public List<Payment> Payments { get; }
    public List<Favorite> Favorites { get; }
    public List<Review> Reviews { get; }
}
