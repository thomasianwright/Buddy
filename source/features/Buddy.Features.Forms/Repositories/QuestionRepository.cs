using Buddy.Features.Forms.Contracts.Repositories;
using Buddy.Features.Forms.Entities;
using Buddy.Infrastructure.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;

namespace Buddy.Features.Forms.Repositories;

public class QuestionRepository : RepositoryBase<FormsDbContext, SurveyQuestion, Guid>, IQuestionRepository
{
    public QuestionRepository(FormsDbContext context, ILogger<QuestionRepository> logger) : base(context, logger)
    {
    }
}