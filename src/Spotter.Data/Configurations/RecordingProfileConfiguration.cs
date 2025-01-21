using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotter.Data.Entities;

namespace Spotter.Data.Configurations;

public class RecordingProfileConfiguration : IEntityTypeConfiguration<RecordingProfile>
{
    public void Configure(EntityTypeBuilder<RecordingProfile> builder)
    {
        builder.HasKey(r => r.Name); // Первичный ключ

        builder.Property(r => r.DisplayNumber)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(r => r.X)
            .IsRequired()
            .HasMaxLength(6);
        
        builder.Property(r => r.Y)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(r => r.Width)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(r => r.Height)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(r => r.Bitrate)
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(r => r.Framerate)
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(r => r.IsCursorTrackingEnabled)
            .IsRequired();

        builder.Property(r => r.ZoomLevel)
            .IsRequired();

        builder.Property(r => r.ZoomSpeed)
            .IsRequired();
    }
}