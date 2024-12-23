using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Reviews.Entities;

public sealed class Review : Entity
{
    public int Rate { get; }
    public string Comment { get; }
    public Product Product { get; }
    public Customer Owner { get; }
}