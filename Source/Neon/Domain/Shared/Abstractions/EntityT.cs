namespace Neon.Domain.Shared.Abstractions;

public abstract class Entity<TId>
{
    public TId Id { get; }
    public DateTime CreatedAt { get; }
    public DateTime ModifiedAt { get; protected set; }

    protected Entity()
    {
    }

    protected Entity(TId id)
    {
        Id = id;
    }
}