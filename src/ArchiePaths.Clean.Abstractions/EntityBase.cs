namespace ArchiePaths.Clean;

/// <summary>
/// Base class for domain entities.
/// For entities that use type other than int for Id, use EntityBase&lt;TId&gt;.
/// </summary>
public abstract class EntityBase : HasDomainEventsBase
{
    public int Id { get; set; }
}

/// <summary>
/// Base class for domain entities, with non-integer identifier.
/// </summary>
/// <typeparam name="TId">Identifier type.</typeparam>
public abstract class EntityBase<TId> : HasDomainEventsBase
    where TId : struct, IEquatable<TId>
{
    public TId Id { get; set; } = default;
}

/// <summary>
/// Base class for domain entities, with strongly typed identifiers.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="TId"></typeparam>
public abstract class EntityBase<T, TId> : HasDomainEventsBase
    where T : EntityBase<T, TId>
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public TId Id { set; get; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}
