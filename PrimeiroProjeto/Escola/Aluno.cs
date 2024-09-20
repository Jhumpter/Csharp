class Aluno
{
    public string  NomeAluno { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
    public double Media => Notas.Average();
    public void ExibirNotas() => Notas.ForEach (nota => Console.WriteLine(nota));
}