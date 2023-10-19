using Buddy.Features.Forms.Entities;
using Buddy.Infrastructure.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;

namespace Buddy.Features.Forms.Repositories;

public class SurveyRepository : RepositoryBase<FormsDbContext, SurveyForm, Guid>
{
    public SurveyRepository(FormsDbContext context, ILogger<SurveyRepository> logger) : base(context, logger)
    {
    }
}