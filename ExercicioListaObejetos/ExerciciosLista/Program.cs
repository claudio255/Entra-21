using ExercicioListaObejetos;
using ExercicioListaObejetos.Exercicio02AlunoLista;

Console.WriteLine(@"-----------MENU---------
1 - Exercicio Triangulo
2 - Exercicio Aluno");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if (opcaoEscolhida == 1)
{
    TrianguloControlador triangulo = new TrianguloControlador();
    triangulo.GerenciarMenu();
}
else if (opcaoEscolhida == 2)
{
    AlunoControler aluno = new AlunoControler();
    aluno.GerenciarMenu();
}
