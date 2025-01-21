using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Spotter.Data.Entities;

namespace Spotter.Data;

public class DatabaseContext : DbContext
{
    public DbSet<AppSettings> AppSettings { get; set; }
    public DbSet<RecordingProfile> RecordingProfiles { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AppSettingsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RecordingProfileConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}