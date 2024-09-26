namespace PrimeiroProjeto.Models;

internal class Song
{   // Creating a constructor to Song
    public Song (Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    // 'public' makes the attribute global, allowing access from outside
    // 'private' restricts the attribute to be accessible only within the class
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; } 
    // Adding "get" and "set" turns an element into a property, changing the naming rules
    // Creating a property to bind name and artist
    public string SummarizedDescription => $"The song {Name} belongs to {Artist}";
    /*A lambda (=>) is used to assign a value to a property, summarizing the process below: 
    { 
        get
        {
            return $"The song {Name} belongs to {Artist}";
        }
    }*/
    public void Technicalsheet()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration} seconds");
    if (Available)
        {
            Console.WriteLine("Available in the plan");
        } else {
            Console.WriteLine("Buy the plus plan");
        }
    }
}