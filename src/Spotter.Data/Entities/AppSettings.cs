namespace Spotter.Data.Entities;

public class AppSettings
{
    public int Id { get; set; }
    public string DefaultSavePath { get; set; } = "";
    public Dictionary<string, string> Hotkeys { get; set; }
    public string Theme { get; set; }
}