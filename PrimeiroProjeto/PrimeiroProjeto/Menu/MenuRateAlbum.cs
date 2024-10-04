using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.Menu;

class MenuRateAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        OptionsTitle("Rate Album");
        Console.Write("Type the band's name to rate the album(-1 to exit): ");
        string ratedAlbumBand = Console.ReadLine()!;
        if (ratedAlbumBand == "-1")
        {
            Console.Clear();
        } else {
            if (registeredBands.ContainsKey(ratedAlbumBand))
            {   
                Band band = registeredBands[ratedAlbumBand];
                Console.Write("Now, type the album's name: ");
                string albumTitle = Console.ReadLine()!;
                if (band.Albums.Any(a => a.Name.Equals(albumTitle))) 
                {
                    Album album = band.Albums.First(a => a.Name.Equals(albumTitle));
                    Console.Write($"What rating do you give to {albumTitle}? ");
                    Reviews rating = Reviews.Parse(Console.ReadLine()!);
                    album.AddRating(rating);
                    Console.WriteLine($"The rating {rating.Rating} was registered for the album {albumTitle} successfully!");
                    Thread.Sleep(1500);
                    Console.Clear();
                } else {
                    Console.WriteLine($"The album {albumTitle} was not found");
                    Thread.Sleep(1500);
                    Execute(registeredBands);
                }
            } else {
                Console.WriteLine($"The band {ratedAlbumBand} was not found");
                Thread.Sleep(1500);
                Execute(registeredBands);
            }
        }
    }
}