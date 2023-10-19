using Buddy.Features.Forms.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buddy.Features.Forms.EntityConfiguration;

public class SurveyFormEntityTypeConfiguration : IEntityTypeConfiguration<SurveyForm>
{
    private const string TableName = "survey_form";
    
    public void Configure(EntityTypeBuilder<SurveyForm> builder)
    {
        builder.ToTable(TableName);
        
        builder.HasKey(x => x.Id);
    }
}