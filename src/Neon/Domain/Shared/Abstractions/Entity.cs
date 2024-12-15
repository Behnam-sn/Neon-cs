namespace Neon.Domain.Shared.Abstractions;

public abstract class Entity
{
    public Guid Id { get; private init; }
    public DateTime CreatedAt { get; private init; }
    public DateTime ModifiedAt { get; private init; }
}