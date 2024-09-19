class Musica
{
    public string nome;
    // public torna o atributo global, podendo ser alterado de fora,
    //private restringe o atributo a apenas a classe
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; } 
    //Atribuir get e set torna o elemento uma propriedade, mudando a regra de nomenclatura
    
    public void FichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao} segundos");
    if (disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else {
            Console.WriteLine("Adquira o plano Plus");
        }
    }
}