using Buddy.Features.Forms.Entities;
using Buddy.Features.Forms.Entities.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buddy.Features.Forms.EntityConfiguration.Questions;

public class NumberQuestionEntityConfiguration : IEntityTypeConfiguration<NumberQuestion>
{
    private const string TableName = "number_question";
    
    public void Configure(EntityTypeBuilder<NumberQuestion> builder)
    {
        builder.ToTable(TableName);

        builder.HasBaseType<SurveyQuestion>();
    }
}