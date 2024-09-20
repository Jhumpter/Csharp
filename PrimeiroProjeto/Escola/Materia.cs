class Materia
{
    public string NomeMateria { get; set; }
    public List<Aluno> alunosMatriculados = new List<Aluno>();
    public void MatricularAluno(Aluno aluno) => alunosMatriculados.Add(aluno);
    public void ExibirAlunosMatriculados() => alunosMatriculados.ForEach(aluno => Console.WriteLine(aluno.NomeAluno));
}