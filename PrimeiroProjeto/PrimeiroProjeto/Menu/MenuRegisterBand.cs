namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

class MenuRegisterBand : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        OptionsTitle("Band registration");
        Console.Write("Type the band's name to register: ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);
        registeredBands.Add(bandName, band); //.Add to add the (element)
        Console.WriteLine($"The band {bandName} was registered!");
        Thread.Sleep(1500); //To wait 1500 miliseconds
        Console.Clear();
    }
}