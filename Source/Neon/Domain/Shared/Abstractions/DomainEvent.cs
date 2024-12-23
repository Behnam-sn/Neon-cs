namespace Neon.Domain.Shared.Abstractions;

public abstract record DomainEvent(DomainEventId Id) : IDomainEvent;
