class Episode {
    public Episode(string name, int number, int duration)
    {
        Name = name;
        Number = number;
        Duration = duration;
    }
    private string guests = "";
    public string Name { get; }
    public int Number { get; }
    public int Duration { get; }
    public string Summary => $"Episode {Number}: {Name} ({Duration} seconds) \nGuests:\n{guests}";
    public void AddGuest(string guest)
    {
        guests += $"{guest}\n";
    }
}