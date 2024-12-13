using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Products;
using Neon.WebApi.Domain.Entities.Users;

namespace Neon.WebApi.Domain.Entities.Favorites;

public sealed class Favorite : Entity
{
    public Product Product { get; private set; }
    public Customer Owner { get; private set; }
}