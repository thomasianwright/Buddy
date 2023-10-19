using Buddy.Features.Data.Contracts.Repositories;
using Buddy.Features.Data.Entities;
using Buddy.Infrastructure.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;

namespace Buddy.Features.Data.Repositories;

public class JourneyDataRepository : RepositoryBase<DataDbContext, JourneyData, Guid>, IJourneyDataRepository
{
    public JourneyDataRepository(DataDbContext context, ILogger<JourneyDataRepository> logger) : base(context, logger)
    {
    }
}