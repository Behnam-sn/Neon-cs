namespace Neon.Domain.Shared.Abstractions;

public interface IDomainEvent
{
    public DomainEventId Id { get; }
}
