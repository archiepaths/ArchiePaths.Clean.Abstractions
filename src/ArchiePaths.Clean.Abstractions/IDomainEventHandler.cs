using Mediator;

namespace ArchiePaths.Clean;

/// <summary>
/// Interface for a notification handler.
/// </summary>
/// <typeparam name="T">Type of domain event.</typeparam>
public interface IDomainEventHandler<T> : INotificationHandler<T> where T : IDomainEvent
{
}
