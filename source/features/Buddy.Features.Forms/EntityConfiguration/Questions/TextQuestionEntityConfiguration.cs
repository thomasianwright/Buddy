using Buddy.Features.Forms.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buddy.Features.Forms.EntityConfiguration.Questions;

public class TextQuestionEntityConfiguration : IEntityTypeConfiguration<TextQuestionEntityConfiguration>
{
    private const string TableName = "text_question";
    public void Configure(EntityTypeBuilder<TextQuestionEntityConfiguration> builder)
    {
        builder.ToTable(TableName);

        builder.HasBaseType<SurveyQuestion>();
    }
}