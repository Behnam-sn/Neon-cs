namespace Neon.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get; private init; }
}