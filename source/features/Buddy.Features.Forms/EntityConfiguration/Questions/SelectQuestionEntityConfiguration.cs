using System.Text.Json;
using Buddy.Features.Forms.Entities;
using Buddy.Features.Forms.Entities.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buddy.Features.Forms.EntityConfiguration.Questions;

public class SelectQuestionEntityConfiguration : IEntityTypeConfiguration<SelectQuestion>
{
    private const string TableName = "select_question";

    public void Configure(EntityTypeBuilder<SelectQuestion> builder)
    {
        builder.ToTable(TableName);

        builder.HasBaseType<SurveyQuestion>();

        builder.Property(x => x.Select)
            .HasConversion(x => JsonSerializer.Serialize(x, JsonSerializerOptions.Default),
                x => JsonSerializer.Deserialize<Dictionary<int, string>>(x, JsonSerializerOptions.Default) ??
                     new Dictionary<int, string>());
    }
}