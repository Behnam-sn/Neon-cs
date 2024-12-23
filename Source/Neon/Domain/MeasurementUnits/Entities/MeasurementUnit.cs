using Neon.Domain.MeasurementUnitValues.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.MeasurementUnits.Entities;

public sealed class MeasurementUnit : Entity
{
    public string Name { get; }

    // Navigations
    public List<MeasurementUnitValue> Values { get; }
}
