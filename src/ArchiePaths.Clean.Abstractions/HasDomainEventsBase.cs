namespace ArchiePaths.Clean;

/// <summary>
/// Base class for entities which raise domain events.
/// </summary>
public abstract class HasDomainEventsBase : IHasDomainEvents
{
    private readonly List<IDomainEvent> _domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvents 
        => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEventBase domainEvent)
        => _domainEvents.Add(domainEvent);

    public void ClearDomainEvents()
        => _domainEvents.Clear();
}