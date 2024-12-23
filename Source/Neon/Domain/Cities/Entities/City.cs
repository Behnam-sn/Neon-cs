using Neon.Domain.Countries.Entities;
using Neon.Domain.Provinces.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Cities.Entities;

public sealed class City : Entity
{
    public string Name { get; }
    public Country Country { get; }
    public Province Province { get; }
}
