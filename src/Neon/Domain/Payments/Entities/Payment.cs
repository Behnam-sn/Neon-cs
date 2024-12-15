using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Payments.Entities;

public sealed class Payment : Entity
{
    public Customer Owner { get; }
}