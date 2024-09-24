using System.ComponentModel;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDaBanda()
    {
        Console.WriteLine($"Músicas do álbum {Nome}\n");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração do álbum: {DuracaoTotal} segundos");
    }

}