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

        [Fact]
        public void Validar_AdicionarAluno()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();
            
            aluno.Nome = "claudio";
            aluno.Idade = 22;
            aluno.MateriaFavorita = "fisica";
            aluno.Nota1 = 8.3;
            aluno.Nota2 = 9;
            aluno.Nota3 = 7.4;
            aluno.Status = AlunoStatus.Aprovado;
            
            alunoServico.AdicionarAluno("claudio", 22, "fisica", 8.3, 9, 7.4);

            var addAluno = alunoServico.AdicionarAluno(aluno.Nome, aluno.Idade, aluno.MateriaFavorita, aluno.Nota1, aluno.Nota2, aluno.Nota3);

            addAluno.Should().Be(true);
        }

    }
}
