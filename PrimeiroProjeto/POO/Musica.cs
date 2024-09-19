class Musica
{
    public string nome;
    // public torna o atributo global, podendo ser alterado de fora,
    //private restringe o atributo a apenas a classe
    public string artista;
    public int duracao;
    private bool disponivel;
    public void EscreverDisponivel(bool value)
    {
        //Aqui com um if é possível permitir ou negar alguém de alterar se está disponível ou não
        disponivel = value;
    }
    public bool LerDisponivel()
    {  
        return disponivel;
    }
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