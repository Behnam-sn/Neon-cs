namespace Neon.Domain.Shared.Abstractions;

public readonly struct DomainEventId
{
    public Guid Value { get; }

    private DomainEventId(Guid value)
    {
        Value = value;
    }

    public static DomainEventId Create()
    {
        return new(Guid.NewGuid());
    }
}