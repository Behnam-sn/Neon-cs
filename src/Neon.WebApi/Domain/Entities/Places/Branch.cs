namespace Neon.WebApi.Domain.Entities.Places;

public sealed class Branch : Place
{
    public Shop Shop { get; private set; }
}