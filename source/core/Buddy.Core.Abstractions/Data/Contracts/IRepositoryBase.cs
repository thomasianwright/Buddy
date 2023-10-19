using System.Linq.Expressions;
using Buddy.Core.Abstractions.Data.Contracts;
using FluentResults;

namespace Buddy.Infrastructure.EntityFramework.Contracts;

public interface IRepositoryBase<TEntity, TKey> where TEntity : class, IEntityBase<TKey> where TKey : struct
{
    ValueTask<Result<TEntity>> FindByIdAsync(TKey id, CancellationToken cancellationToken = default);

    ValueTask<Result<IEnumerable<TEntity>>> FindAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default);
    
    ValueTask<Result<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

    ValueTask<Result<IEnumerable<TEntity>>> AddRangeAsync(IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default);
    
    ValueTask<Result> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    
    ValueTask<Result> UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity,
        CancellationToken cancellationToken = default);
    
    ValueTask<Result> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    
    ValueTask<Result> DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    
    ValueTask<Result> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default);
    
    ValueTask<Result> DeleteAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    
    ValueTask<Result> SaveChangesAsync(CancellationToken cancellationToken = default);
}