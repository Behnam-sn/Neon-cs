namespace Neon.Domain.Shared.ValueObjects;

public readonly struct Money
{
    public decimal Amount { get; }
    public string Currency { get; }
}