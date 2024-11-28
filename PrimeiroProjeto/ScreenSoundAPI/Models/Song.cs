

using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Song
{
    //Getting 4 fields (artist, song name, duration and genre)
    [JsonPropertyName("song")]
    //It's an attribute used to bind the property from the json to the property "Name"
    //Since these properties may be null, they are indicated by a question mark(?)
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string Genre { get; set; }
    public void ShowSongDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Song: {Name}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
