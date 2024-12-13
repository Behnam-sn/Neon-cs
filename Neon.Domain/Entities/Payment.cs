using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities;

public sealed class Payment : Entity
{
    public Customer Owner { get; private set; }
}