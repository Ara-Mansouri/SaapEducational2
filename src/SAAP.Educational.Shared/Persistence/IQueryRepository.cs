using SAAP.Educational.Shared.Domain;

namespace SAAP.Educational.Shared.Persistence;

public interface IQueryRepository<TEntity, in TKey>
    where TEntity : Entity<TKey>
    where TKey : notnull
{
    Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<TEntity>> ListAsync(CancellationToken cancellationToken = default);
}
