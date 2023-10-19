using System.Linq.Expressions;
using Buddy.Data.Contracts;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Buddy.Infrastructure.EntityFramework.Repositories;

public abstract class RepositoryBase<TContext, TEntity, TKey> : IRepositoryBase<TEntity, TKey>
    where TContext : DbContext
    where TEntity : class, IEntityBase<TKey>
    where TKey : struct
{
    protected ILogger Logger;
    protected DbSet<TEntity> Table { get; }
    protected TContext Context { get; }
    
    protected RepositoryBase(TContext context, ILogger logger)
    {
        Logger = logger;
        Context = context;
        Table = Context.Set<TEntity>();
    }
    
    public ValueTask<Result<TEntity>> FindByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<IEnumerable<TEntity>>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result<IEnumerable<TEntity>>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> DeleteAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Result> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}