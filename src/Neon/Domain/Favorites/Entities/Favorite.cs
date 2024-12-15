using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Favorites;

public sealed class Favorite : Entity
{
    public Product Product { get; private set; }
    public Customer Owner { get; private set; }
}