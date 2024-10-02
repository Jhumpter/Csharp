namespace PrimeiroProjeto.Menu;
using PrimeiroProjeto.Models;

internal class Menu
{
    public static void OptionsTitle(string titulo)
    {
        int qtdeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public virtual void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        
    }
    /*This function (Execute) will serve as a base for the anothers classes functions, so the pair "virtual(in the parent class)
     and override (for the class child)" and to bring in the lines from the parent class, we use "base.(functionName)()*/
}