using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Favorites;

public sealed class Favorite : Entity
{
    public Product Product { get; }
    public Customer Owner { get; }
}