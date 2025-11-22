using ArchiePaths.Clean.Data;

namespace ArchiePaths.Clean.Abstractions;

public interface IRepository<T> : IRepositoryBase<T>
  where T : class, IAggregateRoot
{
}
