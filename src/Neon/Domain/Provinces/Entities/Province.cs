using Neon.Domain.Countries.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Provinces.Entities;

public sealed class Province : Entity
{
    public string Name { get; }
    public Country Country { get; }
}
