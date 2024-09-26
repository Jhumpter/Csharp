// Screen Sound
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

string welcomeMessage = "Welcome to Screen Sound";
// In C#, double quotes ("") are more common, and ';' is mandatory
// Console.WriteLine() to write on console and skip a line
// Console.Write() writes without skipping a line
// To create a function without a "return", it uses void
Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>(); // Bands will be the keys and the elements will be lists with the ratings
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
    Console.WriteLine(welcomeMessage);
}

void ShowMenu()
{
    ShowMessage();
    Console.WriteLine(@"
Type 1 to add a band
Type 2 to show all the bands
Type 3 to rate a band
Type 4 to show a band's average rating
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
        case 2: ShowBands();
            break;
        case 3: RateBand();
            break;
        case 4: BandsAverage();
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
    registeredBands.Add(bandName, new List<int>()); //.Add to add the (element)
    Console.WriteLine($"The band {bandName} was registered!");
    Thread.Sleep(1500); //To wait 1500 miliseconds
    Console.Clear();
    ShowMenu();
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
            Console.Write($"What rating do you give to {ratedBand}?");
            int r = int.Parse(Console.ReadLine()!);
            registeredBands[ratedBand].Add(r);
            Console.WriteLine($"The rating {r} was registered for the band {ratedBand} successfully!");
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

void BandsAverage()
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
            /*int summation = 0;
            int c = 0;
            foreach (int rate in registeredBands[checkedBand])
            {
                summation += r;
                c++;
            }
            if (c == 0)
            {
                Console.WriteLine($"The band {checkedBand} doesn't have any ratings yet");
                Thread.Sleep(1500);
                Console.Clear();
                BandsAverage();
            } else {
                float averages = summation/c;
                Console.WriteLine($"The band {checkedBand} has a rating of {averages}");
                Thread.Sleep(1500);
                Console.Clear();
                ShowMenu();
            }*/
            List<int> bandRating = registeredBands[checkedBand];
            double average = bandRating.Average();
            if (average == 0)
            {
                Console.WriteLine($"A band {checkedBand} doesn't have any ratings yet");
                Thread.Sleep(1500);
                Console.Clear();
                BandsAverage();
            } else {
                Console.WriteLine($"The band {checkedBand} has a rating of {average}");
                Thread.Sleep(1500);
                Console.Clear();
                ShowMenu();
            }
        } else {
            Console.WriteLine($"The band {checkedBand} was not found");
            Thread.Sleep(1500);
            BandsAverage();
        }
    }
}

ShowMenu();