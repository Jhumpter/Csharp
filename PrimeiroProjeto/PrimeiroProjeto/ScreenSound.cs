// Screen Sound
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

string mensagemBoasVindas = "Bem vindo ao Screen Sound";
// No C# as aspas duplas ("") são mais usuais e o ; é obrigatório
// Console.WriteLine() para escrever no console e pular linha
// Console.Write() escreve sem pular linha
// Para criar uma função sem return utiliza-se void
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); // As bandas serão as chaves e o elemento serão listas com as notas
void ExibirMensagem()
{   // Para criar um verbatim literal, utiliza-se @ antes das aspas
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirMenu()
{
    ExibirMensagem();
    Console.WriteLine(@"
Digite 1 para adicionar uma banda
Digite 2 para ver todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite -1 para sair
");
    Console.Write("\nDigite sua opção:");
    // Console.ReadLine lê a informação retornada pelo usuário
    // É possível colocar '!' para informar que valor nulo não é aceito
    int opcaoMenu = int.Parse(Console.ReadLine()!);
    // int.Parse() para transformar em inteiro
    switch(opcaoMenu)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBandas();
            break;
        case -1: Console.WriteLine("Até a próxima!");
            Thread.Sleep(1500);
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear(); //Para limpar o console
    TituloOpcoes("Registro de bandas");
    Console.Write("Digite o nome da banda a ser registrada:");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); //.Add para adicionar o (elemento)
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!");
    Thread.Sleep(1500); //Para esperar 1500 milisegundos
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    TituloOpcoes("Bandas Registradas");
    /*for (int i = 0; i < bandasRegistradas.Count; i++)
    {
        Console.WriteLine($"Banda: {bandasRegistradas[i]}");
    }*/
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void TituloOpcoes(string titulo)
{
    int qtdeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    TituloOpcoes("Avaliar Banda");
    Console.Write("Digite o nome da banda a ser avaliada (-1 para sair): ");
    string bandaAvaliada = Console.ReadLine()!;
    if (bandaAvaliada == "-1")
    {
        Console.Clear();
        ExibirMenu();
    } else {
        if (bandasRegistradas.ContainsKey(bandaAvaliada))
        {
            Console.Write($"Qual nota você dá para a banda {bandaAvaliada}? ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[bandaAvaliada].Add(nota);
            Console.WriteLine($"A nota {nota} foi registrada para a banda {bandaAvaliada} com sucesso!");
            Thread.Sleep(1500);
            Console.Clear();
            ExibirMenu();
        } else {
        Console.WriteLine($"A banda {bandaAvaliada} não foi encontrada");
        Thread.Sleep(1500);
        AvaliarBanda();
        }
    }
    
}

void MediaBandas()
{
    Console.Clear();
    TituloOpcoes("Notas das bandas");
    Console.Write("Digite uma banda para conferir a avaliação média dela (-1 para sair): ");
    string bandaConferida = Console.ReadLine()!;
    if (bandaConferida == "-1")
    {
        Console.Clear();
        ExibirMenu();
    } else {
        if (bandasRegistradas.ContainsKey(bandaConferida))
        {   
            /*int somatorio = 0;
            int c = 0;
            foreach (int nota in bandasRegistradas[bandaConferida])
            {
                somatorio += nota;
                c++;
            }
            if (c == 0)
            {
                Console.WriteLine($"A banda {bandaConferida} ainda não possui avaliações");
                Thread.Sleep(1500);
                Console.Clear();
                MediaBandas();
            } else {
                float mediaNotas = somatorio/c;
                Console.WriteLine($"A banda {bandaConferida} possui nota {mediaNotas}");
                Thread.Sleep(1500);
                Console.Clear();
                ExibirMenu();
            }*/
            List<int> notasDaBanda = bandasRegistradas[bandaConferida];
            double media = notasDaBanda.Average();
            if (media == 0)
            {
                Console.WriteLine($"A banda {bandaConferida} ainda não possui avaliações");
                Thread.Sleep(1500);
                Console.Clear();
                MediaBandas();
            } else {
                Console.WriteLine($"A banda {bandaConferida} possui em média a nota {media}");
                Thread.Sleep(1500);
                Console.Clear();
                ExibirMenu();
            }
        } else {
            Console.WriteLine($"A banda {bandaConferida} não foi encontrada");
            Thread.Sleep(1500);
            MediaBandas();
        }
    }
}

ExibirMenu();