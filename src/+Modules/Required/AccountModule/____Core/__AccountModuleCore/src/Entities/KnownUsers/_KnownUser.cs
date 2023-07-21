namespace AccountModuleCore.Entities;
public class KnownUser : BaseEntityTracked<Guid>, IAggregateRoot
{
    private KnownUser() { }
    public KnownUser(Guid userId)
    {
        UserId = Guard.Against.NullOrEmpty(userId);
    }
    public KnownUser(Guid id, Guid userId)
    {
        UserId = Guard.Against.NullOrEmpty(userId);
    }

    [MaxLength(100)]
    public string? Name { get; private set; } = "";
    public Guid UserId { get; private set; } = Guid.Empty;
    [MaxLength(100)]
    public string? EmailAddress { get; private set; }


    public DateTime? LastAgreedToTOS { get; private set; }


    public bool IsActive { get; private set; } = true;
    public bool IsJokerFlag { get; private set; } = false;

    public void AgreeToTOS()
    {
        LastAgreedToTOS = DateTime.UtcNow;
    }

    public void SetName(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }
    public void SetEmail(string emailAddress)
    {
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress, nameof(emailAddress));
    }

    public void SetJokerFlagToTrue()
    {
        // if we really think its right, probably want to throw some events, do other sophisticated things too.
        IsJokerFlag = true;
    }
    public void SetJokerFlagToFalse()
    {
        // if we really think its right, probably want to throw some events, do other sophisticated things too.
        IsJokerFlag = false;
    }

    public void Inactivate()
    {
        IsActive = false;
    }
    public void Activate()
    {
        IsActive = true;
    }
}
