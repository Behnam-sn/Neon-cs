namespace Neon.Domain.Shared.Abstractions;

public interface IDomainEvent
{
    public Guid Id { get; }
}