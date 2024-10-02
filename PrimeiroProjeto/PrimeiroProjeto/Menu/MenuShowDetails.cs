namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

internal class MenuShowDetails : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        OptionsTitle("Band ratings");
        Console.Write("Type a band to check the average rating (-1 to exit): ");
        string checkedBand = Console.ReadLine()!;
        if (checkedBand == "-1")
        {
            Console.Clear();
        } else {
            if (registeredBands.ContainsKey(checkedBand))
            {   
                Band band = registeredBands[checkedBand];
                    Console.WriteLine($"The band {checkedBand} has a rating of {band.Average}");
                    Thread.Sleep(1500);
                    Console.Clear();
            } else {
                Console.WriteLine($"The band {checkedBand} was not found");
                Thread.Sleep(1500);
                Execute(registeredBands);
            }
        }
    }
}