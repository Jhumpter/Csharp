class Episode {
    public Episode(string name, int number, int duration)
    {
        Name = name;
        Number = number;
        Duration = duration;
    }
    private List<string> guests = new();
    public string Name { get; }
    public int Number { get; }
    public int Duration { get; }
    public string Summary => $"Episode {Number}: {Name} ({Duration} seconds) \nGuests: {string.Join(", ", guests)}";
    // string.Join adds the list "guests" to the string, using the separator ", "
    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}