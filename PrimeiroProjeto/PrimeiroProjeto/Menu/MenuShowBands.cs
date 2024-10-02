namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

class MenuShowBands : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        OptionsTitle("Registered bands");
        /*for (int i = 0; i < registeredBands.Count; i++)
        {
            Console.WriteLine($"Band: {registeredBands[i]}");
        }*/
        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"Band: {band}");
        }
        Console.WriteLine("\nType anything to back to the menu");
        Console.ReadKey();
        Console.Clear();
    }
}