using Neon.Domain.MeasurementUnits.Entities;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.MeasurementUnitValues.Entities;

public sealed class MeasurementUnitValue : Entity
{
    public Guid MeasurementUnitId { get; }
    public string Value { get; }

    // Navigations
    public MeasurementUnit MeasurementUnit { get; }
}