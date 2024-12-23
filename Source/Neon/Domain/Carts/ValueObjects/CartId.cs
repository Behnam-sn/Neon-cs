namespace Neon.Domain.Carts.ValueObjects;

public readonly struct CartId
{
    public Guid Value { get; }

    private CartId(Guid value)
    {
        Value = value;
    }

    public static CartId Create()
    {
        return new(Guid.NewGuid());
    }
}