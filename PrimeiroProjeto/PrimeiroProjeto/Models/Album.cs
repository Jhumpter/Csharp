namespace PrimeiroProjeto.Models;

internal class Album
{
    private List<Song> songs = new List<Song>();
    public Album(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public int TotalDuration => songs.Sum(m => m.Duration);
    public List<Song> Songs => songs;
    public void AddSong(Song song)
    {
        songs.Add(song);
    }
    public void ShowSongsFromBand()
    {
        Console.WriteLine($"Songs from {Name}\n");
        foreach (Song song in songs)
        {
            Console.WriteLine($"Song: {song.Name}");
        }
        Console.WriteLine($"Album duration: {TotalDuration} seconds");
    }

}