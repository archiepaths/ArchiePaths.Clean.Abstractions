using Mediator;
using Microsoft.Extensions.Logging;

namespace ArchiePaths.Clean.Abstractions;

public class MediatorDomainEventDispatcher(IMediator mediator, ILogger<MediatorDomainEventDispatcher> logger) : IDomainEventDispatcher
{
  private readonly IMediator _mediator = mediator;
  private readonly ILogger<MediatorDomainEventDispatcher> _logger = logger;

  public async Task DispatchAndClearEvents(IEnumerable<IHasDomainEvents> entitiesWithEvents)
  {
    foreach (var entity in entitiesWithEvents)
    {
      if (entity is IHasDomainEvents hasDomainEvents)
      {
        IDomainEvent[] domainEvents = hasDomainEvents.DomainEvents.ToArray();
        hasDomainEvents.ClearDomainEvents();

        foreach (var domainEvent in domainEvents)
          await _mediator.Publish(domainEvent).ConfigureAwait(false);
      }
      else
      {
        _logger.LogError(
          "Entity of type {EntityType} does not inherit from {BaseType}. Unable to clear domain events.",
          entity.GetType().Name,
          nameof(IHasDomainEvents));
      }
    }
  }
}
