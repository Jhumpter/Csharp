Aluno aluno1 = new Aluno();
aluno1.NomeAluno = "João";
aluno1.Idade = 14;
aluno1.Notas.Add(10);
aluno1.Notas.Add(0);
Aluno aluno2 = new Aluno();
aluno2.NomeAluno = "André";
aluno2.Idade = 15;
aluno2.Notas.Add(10);
aluno2.Notas.Add(9);

Materia pt = new Materia();
pt.NomeMateria = "Português";
pt.MatricularAluno(aluno1);
Materia mat = new Materia();
mat.NomeMateria = "Matemática";
mat.MatricularAluno(aluno2);

Professor prof1 = new Professor();
prof1.NomeProf = "Paulo";
prof1.Disciplinas.Add(pt);
Professor prof2 = new Professor();
prof2.NomeProf = "Bianca";
prof2.Disciplinas.Add(pt);
prof2.Disciplinas.Add(mat);

Console.WriteLine(aluno1.Media);
Console.WriteLine(aluno2.Media);
aluno1.ExibirNotas();
pt.ExibirAlunosMatriculados();
mat.ExibirAlunosMatriculados();
Console.WriteLine(prof1.NomeProf);