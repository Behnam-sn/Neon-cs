using Neon.Domain.Carts.ValueObjects;
using Neon.Domain.Shared.Abstractions;

namespace Neon.Domain.Carts.Events;

public sealed record CartCreatedDomainEvent(DomainEventId Id, CartId CartId, Guid OwnerId, Guid ShopId) : DomainEvent(Id);