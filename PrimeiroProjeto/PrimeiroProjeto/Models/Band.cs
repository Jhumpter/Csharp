namespace PrimeiroProjeto.Models;

internal class Band
{   
    private List<Album> albums = new List<Album>();
    private List<int> ratings = new();
    public Band(string name)
    {
        Name = name;
    }
    public string  Name { get; }
    public double Average => ratings.Average();
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(int rating)
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