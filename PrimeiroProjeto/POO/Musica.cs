class Musica
{   // Criando um construtor para Musica
    public Musica (Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    // public torna o atributo global, podendo ser alterado de fora,
    //private restringe o atributo a apenas a classe
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } 
    //Atribuir get e set torna o elemento uma propriedade, mudando a regra de nomenclatura
    //Ciando propriedade para juntar nome e artista
    public string DescricaoResumida => $"A música {Nome} pertence a {Artista}";
    /*O lambda (=>) serve para atribuir um valor à propriedade, resumindo o seguinte processo:
    { 
        get
        {
            return $"A música {Nome} pertence a {Artista}";
        }
    }*/
    public void FichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
    if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else {
            Console.WriteLine("Adquira o plano Plus");
        }
    }
}