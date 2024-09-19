// Screen Sound
string mensagemBoasVindas = "Bem vindo ao Screen Sound";
// No C# as aspas duplas ("") são mais usuais e o ; é obrigatório
// Console.WriteLine() para escrever no console e pular linha
// Console.Write() escreve sem pular linha
// Para criar uma função sem return utiliza-se void
List<string> bandasRegistradas = new List<string>();
//List<tipo dos elementos> nomedalista = new List<tipo>();
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
        case 3: Console.WriteLine("Opção {0}", opcaoMenu); // Outra forma de escrever
            break;
        case 4: Console.WriteLine("Opção " + opcaoMenu);
            break;
        case -1: Console.WriteLine("Opção " + opcaoMenu);
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
    bandasRegistradas.Add(nomeDaBanda); //.Add para adicionar o (elemento)
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!");
    Thread.Sleep(2000); //Para esperar 2000 milisegundos
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
    foreach (string banda in bandasRegistradas)
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
ExibirMenu();