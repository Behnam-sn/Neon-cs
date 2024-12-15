using Neon.Domain.Addresses.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;

namespace Neon.Domain.Branches.Entities;

public sealed class Branch : Entity
{
    public Address Address { get; }
    public Shop Shop { get; }
}