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

    public virtual async ValueTask<Result<TEntity>> FindByIdAsync(TKey id,
        CancellationToken cancellationToken = default)
    {
        var result = await Table.FindAsync(new object[] { id }, cancellationToken);

        if (result == null)
        {
            return Result.Fail<TEntity>($"Entity with id {id} not found");
        }

        return Result.Ok(result);
    }

    public virtual ValueTask<Result<IEnumerable<TEntity>>> FindAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var result = Table.Where(predicate);

        return ValueTask.FromResult(Result.Ok(result.AsEnumerable()));
    }

    public virtual ValueTask<Result<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        try
        {
            var result = Table.Add(entity);
            return ValueTask.FromResult(Result.Ok(result.Entity));
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Error adding entity");
            return ValueTask.FromResult(Result.Fail<TEntity>(e.Message));
        }
    }

    public virtual ValueTask<Result> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        try
        {
            Table.AddRange(entities);
            return ValueTask.FromResult(Result.Ok());
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Error adding entities");
            return ValueTask.FromResult(Result.Fail(e.Message));
        }
    }

    public virtual ValueTask<Result> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        try
        {
            Table.Update(entity);

            return ValueTask.FromResult(Result.Ok());
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Error updating entity");
            return ValueTask.FromResult(Result.Fail(e.Message));
        }
    }

    public virtual ValueTask<Result> UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public virtual async ValueTask<Result> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        try
        {
            await Table.ExecuteDeleteAsync(cancellationToken: cancellationToken);
            
            return Result.Ok();
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Error deleting entity");
            return Result.Fail(e.Message);
        }
    }

    public virtual ValueTask<Result> DeleteRangeAsync(IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public virtual ValueTask<Result> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public virtual ValueTask<Result> DeleteAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public virtual async ValueTask<Result> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await Context.SaveChangesAsync(cancellationToken);
            
            return Result.Ok();
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Error saving changes");
            
            return Result.Fail(e.Message);
        }
    }
}