using PrimeiroProjeto.Models;
using PrimeiroProjeto.Menu;
// "using is like an export

Dictionary<string, Band> registeredBands = new();
// Bands will be the keys and the elements will be lists with the ratings
void ShowMessage()
{   // To create a verbatim string literal, it uses @ before the quotes
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Welcome to Screen Sound");
}

void ShowMenu()
{
    ShowMessage();
    Console.WriteLine(@"
Type 1 to add a band
Type 2 to register an album for a band
Type 3 to show all the bands
Type 4 to rate a band
Type 5 to show a band's details
Type -1 to exit
");
    Console.Write("\nType your option: ");
    // Console.ReadLine read the information provided by the user
    // It's possible to put "!" to indicate that a null value is not accepted
    int menuOption = int.Parse(Console.ReadLine()!);
    // int.Parse() to convert it into a integer
    Dictionary<int, Menu> menuCall = new()
    {
        { 1, new MenuRegisterBand() },
        { 2, new MenuRegisterAlbum() },
        { 3, new MenuShowBands() },
        { 4, new MenuRateBand() },
        { 5, new MenuShowDetails() },
        { -1, new MenuExit() }
    };
    if (menuCall.ContainsKey(menuOption))
    {
        Menu menu = menuCall[menuOption];
        menu.Execute(registeredBands);
        if (menuOption != -1) ShowMenu();
    } else {
        Console.WriteLine("Invalid option");
    }
}

ShowMenu();