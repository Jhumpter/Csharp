class Podcast{
    private List<Episode> episodes = new List<Episode>();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }
    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes = 0;
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
        TotalEpisodes++;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Podcast: {Name}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Episodes:");
        foreach (Episode episode in episodes)
        {
            Console.WriteLine(episode.Summary);
        }
    }
}