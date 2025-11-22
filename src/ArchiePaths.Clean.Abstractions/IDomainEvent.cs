using Mediator;

namespace ArchiePaths.Clean;

/// <summary>
/// Interface for a domain event
/// </summary>
public interface IDomainEvent : INotification
{
    /// <summary>
    /// Time at which the event occurred.
    /// </summary>
    DateTime DateOccurred { get; }
}