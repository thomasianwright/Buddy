using Buddy.Features.Forms.Entities;
using Buddy.Features.Forms.Entities.Questions;
using Microsoft.EntityFrameworkCore;

namespace Buddy.Features.Forms;

public class FormsDbContext : DbContext
{
    public DbSet<SurveyForm> SurveyForms { get; set; }
    public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
    
    public DbSet<NumberQuestion> NumberQuestions { get; set; }
    public DbSet<TextQuestion> TextQuestions { get; set; }
    public DbSet<SelectQuestion> SelectQuestions { get; set; }
    
    public FormsDbContext(DbContextOptions<FormsDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FormsDbContext).Assembly);
    }
}