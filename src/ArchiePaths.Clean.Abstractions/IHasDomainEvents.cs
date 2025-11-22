namespace ArchiePaths.Clean;

/// <summary>
/// Interface for entities which raise domain events
/// </summary>
public interface IHasDomainEvents
{
    /// <summary>
    /// Get domain events for this entity, as a read-only list.
    /// </summary>
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }

    /// <summary>
    /// Clear domain events.
    /// </summary>
    void ClearDomainEvents();
}