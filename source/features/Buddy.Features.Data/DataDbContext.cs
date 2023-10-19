using Buddy.Features.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Buddy.Features.Data;

public class DataDbContext : DbContext
{
    public DbSet<DataSchema> DataSchema { get; set; }
    public DbSet<JourneyData> JourneyData { get; set; }
    
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
    {
    }
}