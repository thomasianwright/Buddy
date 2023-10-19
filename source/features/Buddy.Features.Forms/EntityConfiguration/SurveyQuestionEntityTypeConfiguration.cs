using Buddy.Features.Forms.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Buddy.Features.Forms.EntityConfiguration;

public class SurveyQuestionEntityTypeConfiguration : IEntityTypeConfiguration<SurveyQuestion>
{
    private const string TableName = "survey_question";
    
    public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
    {
        builder.ToTable(TableName);

        builder.UseTptMappingStrategy();

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => new { x.SurveyFormId, x.VariableName })
            .IsUnique();

        builder
            .HasOne(x => x.SurveyForm)
            .WithMany(x => x.Questions)
            .HasForeignKey(x => x.SurveyFormId);
    }
}