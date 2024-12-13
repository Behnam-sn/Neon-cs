using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.Entities.Addresses;

namespace Neon.WebApi.Domain.Entities.Places;

public abstract class Place : Entity
{
    public Address Address { get; private set; }
}
