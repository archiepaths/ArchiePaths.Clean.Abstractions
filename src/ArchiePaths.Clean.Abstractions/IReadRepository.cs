using ArchiePaths.Clean.Data;

namespace ArchiePaths.Clean.Abstractions;

public interface IReadRepository<T> : IReadRepositoryBase<T>
  where T : class, IAggregateRoot
{
}
