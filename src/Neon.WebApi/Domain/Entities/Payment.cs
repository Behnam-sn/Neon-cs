using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Users;

namespace Neon.WebApi.Domain.Entities;

public sealed class Payment : Entity
{
    public Customer Owner { get; private set; }
}