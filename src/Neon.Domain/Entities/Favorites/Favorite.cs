using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities.Favorites;

public sealed class Favorite : Entity
{
    public Product Product { get; private set; }
    public Customer Owner { get; private set; }
}