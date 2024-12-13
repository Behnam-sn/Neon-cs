using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Users;

namespace Neon.Domain.Entities;

public sealed class Address : Entity
{
    public User Owner { get; private set; }
}
