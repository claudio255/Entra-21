using ExercicioListaObejetos.Exercicio02AlunoLista;
using FluentAssertions;
using Xunit;

namespace ExercicioListaObejetos.Test.Alunos
{
    public class AlunoTest
    {
        [Fact]
        public void Validar_RemoverAluno()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();
            aluno.Nome = "claudio";

            alunoServico.AdicionarAluno("claudio", 22, "matematica", 10, 2, 5);


            var apagarAluno = alunoServico.RemoverAluno(aluno.Nome);

            apagarAluno.Should().Be(true);
        }
    }
}
