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
            var aluno = new AlunoServico();          

            var apagarAluno = aluno.RemoverAluno("claudio");

            apagarAluno.Should().Be(false);
        }
    }
}
