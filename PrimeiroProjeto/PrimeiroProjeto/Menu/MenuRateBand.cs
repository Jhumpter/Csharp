namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

//Since the class MAnueRateBand inherit "OptionsTitle" from the class "Menu", a colon (:) is used to indicate that inheritance relationship
class MenuRateBand : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        OptionsTitle("Rate Band");
        Console.Write("Type the band's name to rate (-1 to exit): ");
        string ratedBand = Console.ReadLine()!;
        if (ratedBand == "-1")
        {
            Console.Clear();
        } else {
            if (registeredBands.ContainsKey(ratedBand))
            {   
                Band band = registeredBands[ratedBand];
                Console.Write($"What rating do you give to {ratedBand}?");
                Reviews rating = Reviews.Parse(Console.ReadLine()!);
                band.AddRating(rating);
                Console.WriteLine($"The rating {rating.Rating} was registered for the band {ratedBand} successfully!");
                Thread.Sleep(1500);
                Console.Clear();
            } else {
            Console.WriteLine($"The band {ratedBand} was not found");
            Thread.Sleep(1500);
            Execute(registeredBands);
            }
        }
        
    }
}