using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;

namespace Neon.Domain.Users.Entities;

public abstract class User : Entity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Email Email { get; private set; }
    public MobilePhoneNumber MobilePhoneNumber { get; private set; }
}
