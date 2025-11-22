namespace ArchiePaths.Clean;

/// <summary>
/// Interface for sending domain events.
/// </summary>
public interface IDomainEventDispatcher 
{
    /// <summary>
    /// Send and clear domain events for entities.
    /// </summary>
    /// <param name="entitiesWithEvents">Entities with events to dispatch.</param>
    /// <returns></returns>
    Task DispatchAndClearEvents(IEnumerable<IHasDomainEvents> entitiesWithEvents);
}
