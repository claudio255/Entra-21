using ExercicioListaObejetos.Exercicio02AlunoLista;
using FluentAssertions;
using Xunit;

namespace ExercicioListaObejetos.Test.Alunos
{
    public class AlunoTest
    {
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


            aluno.Should().Be(aluno);
        }

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
        public void Validar_EditarAluno()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nome = "claudio";
            aluno.Idade = 22;
            aluno.MateriaFavorita = "fisica";
            aluno.CodigoMatricula = 1;

            alunoServico.ObterAlunoPorMatricula(1);

            var editarAluno = alunoServico.EditarDadosCadastrais(aluno.CodigoMatricula, aluno.Idade, aluno.Nome, aluno.MateriaFavorita);
            editarAluno.Should().BeTrue();
        }

        [Fact]
        public void Validar_EditarNotaAlunos()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nota1 = 8;
            aluno.Nota2 = 2;
            aluno.Nota3 = 7.6;
            aluno.CodigoMatricula = 1;

            alunoServico.ObterAlunoPorMatricula(1);

            var editarNota = alunoServico.EditarNotasAluno(aluno.CodigoMatricula, aluno.Nota1, aluno.Nota2, aluno.Nota3);
            editarNota.Should().Be(true);
        }

        [Fact]
        public void Validar_ObterNomes()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nome = "claudio";
            //aluno.Nome = "lucas";

            alunoServico.AdicionarAluno("claudio", 22, "fisica", 1, 1, 1);
            //alunoServico.AdicionarAluno("lucas", 32, "matematica", 2, 3, 4);

            var obterNomes = alunoServico.ObterNomes();
            obterNomes[0].Should().Be(aluno.Nome);
        }

        [Fact]
        public void Validar_ObterMedias()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nota1 = 10;
            aluno.Nota2 = 9;
            aluno.Nota3 = 8;
            double media = (10 + 9 + 8) / 3;
            
            alunoServico.AdicionarAluno("claudio", 22, "fisica", 10, 9, 8);
            

            var obterMedias = alunoServico.ObterMedias();
            obterMedias[0].Should().Be(media);
        }

        [Fact]
        public void Validar_ObterAprovados()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nome = "claudio";

            alunoServico.AdicionarAluno("claudio", 22, "fisica", 10, 10, 10);

            var obterAprovados = alunoServico.ObterAprovados(aluno.Status);
            obterAprovados[0].Should().Be(aluno.Nome);
        }

        [Fact]
        public void Validar_ObterEmExame()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();
            
            aluno.Nome = "teresa";          

            alunoServico.AdicionarAluno("teresa", 18, "geografia", 10, 10, 10);

            var obterEmExame = alunoServico.ObterEmExame();
            obterEmExame[0].Should().Be(aluno.Nome);

        }

        [Fact]
        public void Validar_ObterMediaPorCodigoDeMatricula()
        {
            var aluno = new Aluno();
            var alunoServico = new AlunoServico();

            aluno.Nome = "claudio";
            aluno.Nota1 = 10;
            aluno.Nota2 = 10;
            aluno.Nota3 = 10;
            aluno.CodigoMatricula = 1;

            var media = aluno.CalcularMedia();

            alunoServico.AdicionarAluno("claudio", 22, "fisica", 10, 10, 10);

            var obterAlunoPorCodigoMatricula = alunoServico.ObterMediaPorCodigoMatricula(1);
            obterAlunoPorCodigoMatricula.Should().Be(media);
        }
    }
}
