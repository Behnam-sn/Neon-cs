using Neon.Domain.Abstractions;

namespace Neon.Domain.Entities.Places;

public abstract class Place : Entity
{
    public Address Address { get; private set; }
}
