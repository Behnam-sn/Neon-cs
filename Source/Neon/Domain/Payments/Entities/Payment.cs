using Neon.Domain.Orders.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Payments.Entities;

public sealed class Payment : Entity
{
    public Money Amount { get; }
    public PaymentStates State { get; }
    public Customer Owner { get; }
    public Order Order { get; }
    public Shop Shop { get; }
}
