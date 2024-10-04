namespace PrimeiroProjeto.Models;

internal class Album : IAssessable
{
    private List<Song> songs = new List<Song>();
    private List<Reviews> ratings = new();
    public Album(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public int TotalDuration => songs.Sum(m => m.Duration);
    public List<Song> Songs => songs;

    public double Average 
    {
        get
        {
            if(ratings.Count() == 0) return 0;
            else return ratings.Average(a => a.Rating);
        }
    }

    public void AddRating(Reviews rating)
    {
        ratings.Add(rating);
    }

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