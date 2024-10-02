using System.Data.Common;

namespace PrimeiroProjeto.Models;

internal class Band
{   
    private List<Album> albums = new List<Album>();
    private List<Reviews> ratings = new();
    public Band(string name)
    {
        Name = name;
    }
    public string  Name { get; }
    public double Average 
    {
        get
        {
            if (ratings.Count == 0) return 0;
            else return ratings.Average(a => a.Rating);
        }
    }
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Reviews rating)
    {
        ratings.Add(rating);
    }
    
    public void ShowDiscography()
    {
        Console.WriteLine($"{Name} discography");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration} seconds)");
        }
    }
}