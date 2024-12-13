using Neon.Domain.Abstractions;
using Neon.Domain.Entities.Addresses;

namespace Neon.Domain.Entities.Places;

public abstract class Place : Entity
{
    public Address Address { get; private set; }
}
