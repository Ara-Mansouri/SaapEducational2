namespace SAAP.Educational.Shared.Domain;

public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    where TKey : notnull
{
    protected AggregateRoot(TKey id)
        : base(id)
    {
    }
}
