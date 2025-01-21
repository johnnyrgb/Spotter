using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotter.Data.Entities;

namespace Spotter.Data.Configurations;

public class AppSettingsConfiguration : IEntityTypeConfiguration<AppSettings>
{
    public void Configure(EntityTypeBuilder<AppSettings> builder)
    {
        builder.HasKey(a => a.Id); // Первичный ключ

        builder.Property(a => a.Hotkeys)
            .IsRequired();

        builder.Property(a => a.Theme)
            .IsRequired();
    }
}