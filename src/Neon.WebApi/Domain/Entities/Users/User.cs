using Neon.WebApi.Domain.Abstractions;
using Neon.WebApi.Domain.ValueObjects;

namespace Neon.WebApi.Domain.Entities.Users;

public abstract class User : Entity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Email Email { get; private set; }
    public MobilePhoneNumber MobilePhoneNumber { get; private set; }
}
