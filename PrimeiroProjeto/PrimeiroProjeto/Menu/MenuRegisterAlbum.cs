namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        OptionsTitle("Album registration");
        Console.Write("Type the name of the band the album is from: ");
        string bandAlbumRegister = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandAlbumRegister))
        {
            Console.Write("Now, type the album's name: ");
            string albumTitle = Console.ReadLine()!;
            Band band = registeredBands[bandAlbumRegister];
            band.AddAlbum(new Album(albumTitle));
            Console.WriteLine($"The album {albumTitle} by {bandAlbumRegister} was registered successfully!");
            Thread.Sleep(1500);
            Console.Clear();
        } else {
            Console.WriteLine($"The band {bandAlbumRegister} was not found");
            Thread.Sleep(1500);
            Execute(registeredBands);
        }
        
    }
}
