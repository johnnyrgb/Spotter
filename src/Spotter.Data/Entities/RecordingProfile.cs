namespace Spotter.Data.Entities;

public class RecordingProfile
{
    public string Name { get; set; }
    public int DisplayNumber { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Bitrate { get; set; }
    public int Framerate { get; set; }
    public bool IsCursorTrackingEnabled { get; set; }
    public double ZoomLevel { get; set; }
    public double ZoomSpeed { get; set; }
}