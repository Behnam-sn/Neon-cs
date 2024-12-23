using Neon.Domain.CartItems.Entities;
using Neon.Domain.Carts.Enums;
using Neon.Domain.Carts.Events;
using Neon.Domain.Carts.ValueObjects;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Carts.Entities;

public sealed class Cart : AggregateRoot<CartId>
{
    private readonly List<CartItem> _items = [];

    public CartStatus Status { get; private set; }
    public Guid OwnerId { get; }
    public Guid ShopId { get; }
    public Guid? DeliveryId { get; private set; }
    public IEnumerable<CartItem> Items => _items;

    private Cart()
    {
    }

    private Cart(
        CartId id,
        CartStatus status,
        Guid ownerId,
        Guid shopId,
        Guid? deliveryId = null,
        List<CartItem>? items = null
    ) : base(id)
    {
        Status = status;
        OwnerId = ownerId;
        ShopId = shopId;
        DeliveryId = deliveryId;
        _items = items?.ToList() ?? [];
    }

    public static Cart Create(Guid ownerId, Guid shopId)
    {
        var cart = new Cart(
            id: CartId.Create(),
            status: CartStatus.Active,
            ownerId: ownerId,
            shopId: shopId
        );

        cart.RaiseDomainEvent(
            new CartCreatedDomainEvent(
                Id: DomainEventId.Create(),
                CartId: cart.Id,
                OwnerId: cart.OwnerId,
                ShopId: cart.ShopId
            )
        );

        return cart;
    }
}
