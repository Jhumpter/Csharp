using System.ComponentModel;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Músicas do álbum {Nome}\n");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração do álbum: {DuracaoTotal} segundos");
    }

}