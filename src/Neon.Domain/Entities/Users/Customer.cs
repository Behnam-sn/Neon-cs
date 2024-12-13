using Neon.Domain.Entities.Addresses;
using Neon.Domain.Entities.Carts;

namespace Neon.Domain.Entities.Users;

public sealed class Customer : User
{
    public List<Address> Addresses { get; private set; }
    public List<Cart> Carts { get; private set; }
    public List<Payment> Payments { get; private set; }
}
