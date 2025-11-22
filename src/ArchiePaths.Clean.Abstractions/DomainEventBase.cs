namespace ArchiePaths.Clean;

/// <summary>
/// Base class for a domain event.
/// </summary>
public class DomainEventBase : IDomainEvent
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}