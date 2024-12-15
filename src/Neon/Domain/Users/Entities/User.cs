using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;

namespace Neon.Domain.Users.Entities;

public abstract class User : Entity
{
    public string FirstName { get; }
    public string LastName { get; }
    public Email Email { get; }
    public MobilePhoneNumber MobilePhoneNumber { get; }
}
