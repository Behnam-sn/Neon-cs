namespace Neon.Domain.Shared.Abstractions;

public abstract record DomainEvent(Guid Id) : IDomainEvent;
