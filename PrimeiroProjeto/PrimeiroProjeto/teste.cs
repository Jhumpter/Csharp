using System;

class Teste
{
    static void Main(string[] args)
    {
        string teste = "aa";
        teste = teste.PadRight(3, '*');
        Console.Write(teste);
    }
}