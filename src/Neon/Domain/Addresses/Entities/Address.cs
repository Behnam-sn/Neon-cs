using Neon.Domain.Addresses.ValueObjects;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;
using Neon.Domain.Users.Entities;

namespace Neon.Domain.Addresses.Entities;

public sealed class Address : Entity
{
    public AddressName Name { get; private set; }
    public Country Country { get; private set; }
    public Province Province { get; private set; }
    public City City { get; private set; }
    public Region Region { get; private set; }
    public Street Street { get; private set; }
    public PostalCode PostalCode { get; private set; }
    public AddressDetails Details { get; private set; }
    public bool IsPrimary { get; private set; }
    public User Owner { get; private set; }

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
