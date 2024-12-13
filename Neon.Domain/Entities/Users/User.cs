using Neon.Domain.Abstractions;
using Neon.Domain.ValueObjects;

namespace Neon.Domain.Entities.Users;

public abstract class User : Entity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Email Email { get; private set; }
    public MobilePhoneNumber MobilePhoneNumber { get; set; }
}
