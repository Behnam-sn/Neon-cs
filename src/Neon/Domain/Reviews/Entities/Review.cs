using Neon.Domain.Products.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Reviews.Entities;

public sealed class Review : Entity
{
    public int Rate { get; private set; }
    public string Comment { get; private set; }
    public Product Product { get; private set; }
    public Customer Owner { get; private set; }
}