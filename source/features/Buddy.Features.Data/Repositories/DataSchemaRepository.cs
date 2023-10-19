using Buddy.Features.Data.Contracts.Repositories;
using Buddy.Features.Data.Entities;
using Buddy.Infrastructure.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;

namespace Buddy.Features.Data.Repositories;

public class DataSchemaRepository : RepositoryBase<DataDbContext, DataSchema, Guid>, IDataSchemaRepository
{
    public DataSchemaRepository(DataDbContext context, ILogger<DataSchemaRepository> logger) : base(context, logger)
    {
        
    }
}