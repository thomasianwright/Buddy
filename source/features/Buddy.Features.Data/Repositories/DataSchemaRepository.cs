using Buddy.Features.Data.Entities;
using Buddy.Infrastructure.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;

namespace Buddy.Features.Data.Repositories;

public class DataSchemaRepository : RepositoryBase<DataDbContext, DataSchema, Guid>
{
    public DataSchemaRepository(DataDbContext context, ILogger<DataSchemaRepository> logger) : base(context, logger)
    {
        
    }
}