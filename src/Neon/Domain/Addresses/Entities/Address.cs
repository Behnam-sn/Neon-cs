using Neon.Domain.Addresses.Enums;
using Neon.Domain.Addresses.ValueObjects;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Addresses.Entities;

public sealed class Address : Entity
{
    public AddressName Name { get; }
    public Country Country { get; }
    public Province Province { get; }
    public City City { get; }
    public Region Region { get; }
    public Street Street { get; }
    public PostalCode PostalCode { get; }
    public AddressDetails Details { get; }
    public bool IsPrimary { get; private set; }
    public AddressStates State { get; }
    public User Owner { get; }

    private Address()
    {
    }

    public void SetAsPrimary()
    {
        IsPrimary = true;
    }

    public void RemoveAsPrimary()
    {
        IsPrimary = false;
    }
}
