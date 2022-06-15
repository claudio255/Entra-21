using Xunit;

namespace ExercicioListaObejetos.Test.Alunos
{
    public class AlunoTest
    {
        [Fact]
        public void Validar_RemoverAluno()
        {
            var aluno = new Aluno();
            aluno.Apagar = "claudio";

            var apagarAluno = aluno.RemoverAluno();

            apagarAluno.Should().Be(apagarAluno);
        }
    }
}
