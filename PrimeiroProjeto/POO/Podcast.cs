class Podcast{
    private List<Episode> episodes = new List<Episode>();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }
    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Podcast: {Name}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Episodes({TotalEpisodes}):");
        foreach (Episode episode in episodes.OrderBy(e => e.Number))
        {
            Console.WriteLine(episode.Summary);
        }
    }
}