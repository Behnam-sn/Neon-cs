using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Products;
using Neon.WebApi.Domain.Entities.Users;

namespace Neon.WebApi.Domain.Entities.Reviews;

public sealed class Review : Entity
{
    public int Rate { get; private set; }
    public string Comment { get; private set; }
    public Product Product { get; private set; }
    public Customer Owner { get; private set; }
}