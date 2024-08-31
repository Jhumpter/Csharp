// Screen Sound
string mensagemBoasVindas = "Bem vindo ao Screen Sound";
// No C# as aspas duplas ("") são mais usuais e o ; é obrigatório
// Console.WriteLine() para escrever no console e pular linha
// Console.Write() escreve sem pular linha
// Para criar uma função sem return utiliza-se void
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
        case 1: Console.WriteLine("Opção " + opcaoMenu);
            break;
        case 2: Console.WriteLine($"Opção {opcaoMenu}"); // Outra forma de escrever
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

ExibirMensagem();
ExibirMenu();