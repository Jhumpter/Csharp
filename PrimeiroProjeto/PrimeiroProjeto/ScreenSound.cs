using PrimeiroProjeto.Models;
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
    switch(menuOption)
    {
        case 1: RegisterBand();
            break;
        case 2: RegisterAlbum();
            break;
        case 3: ShowBands();
            break;
        case 4: RateBand();
            break;
        case 5: ShowDetails();
            break;
        case -1: Console.WriteLine("See ya!");
            Thread.Sleep(1500);
            break;
        default: Console.WriteLine("Invalid option");
            break;
    }
}

void RegisterBand()
{
    Console.Clear(); //Clear the console
    OptionsTitle("Band registration");
    Console.Write("Type the band's name to register:");
    string bandName = Console.ReadLine()!;
    Band band = new Band(bandName);
    registeredBands.Add(bandName, band); //.Add to add the (element)
    Console.WriteLine($"The band {bandName} was registered!");
    Thread.Sleep(1500); //To wait 1500 miliseconds
    Console.Clear();
    ShowMenu();
}

void RegisterAlbum()
{
    Console.Clear();
    OptionsTitle("Album registration");
    Console.Write("Type the name of the band the album is from");
    string bandAlbumRegister = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandAlbumRegister))
    {
        Console.Write("Now, type the album's name");
        string albumTitle = Console.ReadLine()!;
        Band band = registeredBands[bandAlbumRegister];
        band.AddAlbum(new Album(albumTitle));
        Console.WriteLine($"The album {albumTitle} by {bandAlbumRegister} was registered successfully!");
        Thread.Sleep(1500);
        Console.Clear();
    } else {
        Console.WriteLine($"The band {bandAlbumRegister} was not found");
        Thread.Sleep(1500);
        RegisterAlbum();
    }
    
}

void ShowBands()
{
    Console.Clear();
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
    ShowMenu();
}

void OptionsTitle(string titulo)
{
    int qtdeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RateBand()
{
    Console.Clear();
    OptionsTitle("Rate Band");
    Console.Write("Type the band's name to rate (-1 to exit): ");
    string ratedBand = Console.ReadLine()!;
    if (ratedBand == "-1")
    {
        Console.Clear();
        ShowMenu();
    } else {
        if (registeredBands.ContainsKey(ratedBand))
        {   
            Band band = registeredBands[ratedBand];
            Console.Write($"What rating do you give to {ratedBand}?");
            int rating = int.Parse(Console.ReadLine()!);
            band.AddRating(rating);
            Console.WriteLine($"The rating {rating} was registered for the band {ratedBand} successfully!");
            Thread.Sleep(1500);
            Console.Clear();
            ShowMenu();
        } else {
        Console.WriteLine($"The band {ratedBand} was not found");
        Thread.Sleep(1500);
        RateBand();
        }
    }
    
}

void ShowDetails()
{
    Console.Clear();
    OptionsTitle("Band ratings");
    Console.Write("Type a band to check the average rating (-1 to exit): ");
    string checkedBand = Console.ReadLine()!;
    if (checkedBand == "-1")
    {
        Console.Clear();
        ShowMenu();
    } else {
        if (registeredBands.ContainsKey(checkedBand))
        {   
            Band band = registeredBands[checkedBand];
                Console.WriteLine($"The band {checkedBand} has a rating of {band.Average}");
                Thread.Sleep(1500);
                Console.Clear();
                ShowMenu();
        } else {
            Console.WriteLine($"The band {checkedBand} was not found");
            Thread.Sleep(1500);
            ShowDetails();
        }
    }
}

ShowMenu();