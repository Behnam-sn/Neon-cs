using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shared.ValueObjects;
using Neon.Domain.Users.Enums;

namespace Neon.Domain.Users.Entities;

public abstract class User : Entity
{
    public string FirstName { get; }
    public string LastName { get; }
    public Email Email { get; }
    public MobilePhoneNumber MobilePhoneNumber { get; }
    public GenderTypes Gender { get; }
    public NationalCode NationalCode { get; }
    public DateOnly BirthDate { get; }
}
