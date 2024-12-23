using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Countries.Entities;

public sealed class Country : Entity
{
    public string Name { get; }
}
