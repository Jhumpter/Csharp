namespace PrimeiroProjeto.Menu;

internal class MenuExit : Menu
{
    public void Execute()
    {
        Console.WriteLine("See ya!");
        Thread.Sleep(1500);
    }
}