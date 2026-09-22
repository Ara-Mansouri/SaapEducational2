namespace SAAP.Educational.Shared.Domain;

public abstract class Entity<TKey>
    where TKey : notnull
{
    protected Entity(TKey id)
    {
        Id = id;
    }

    public TKey Id { get; protected init; }
}
