using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObejetos.Exercicio02AlunoLista
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        
        public void AdicionarAluno(string nome, int idade, string materiaFavorita, int codigoMatricula,
            double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.CodigoMatricula = codigoMatricula;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];
                if (aluno.Nome == nome)
                {
                    alunos.Remove(aluno);

                    return true;
                }
            }
            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, int idade, string nome, string materiaFavorita)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                //obtem o aluno na lista de alunos
                Aluno editarAluno = ObterAlunoPorMatricula(codigoMatricula);

                if (editarAluno == null)
                {
                    return false;
                }
                editarAluno.Idade = idade;
                editarAluno.Nome = nome;
                editarAluno.MateriaFavorita = materiaFavorita;
            }
            return true;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno editarNotas = ObterAlunoPorMatricula(codigoMatricula);

                if (editarNotas == null)
                {
                    return false;
                }

                editarNotas.Nota1 = nota1;
                editarNotas.Nota2 = nota2;
                editarNotas.Nota3 = nota3;
            }

            return true;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();

            return nomes;
        }

        public List<double> ObterMedias()
        {
            var medias = new List<double>();

            return medias;
        }

        public List<string> ObterAprovados(AlunoStatus statusAluno)
        {
            //criar um lista de alunos aprovados
            var aprovados = new List<string>();

            //percorre toda a lista de alunos
            for (int i = 0; i < alunos.Count; i++)
            {
                //obtem o aluno atual da lista de alunos
                var aluno = alunos[i];

                //verifica se o status do aluno é o mesmo passado no paraâmetro
                if (aluno.Status == statusAluno)
                {
                    aprovados.Add(aluno.CalcularMedia());
                }
            }
            return aprovados;
        }

        public List<string> ObterReprovados(AlunoStatus reprovado)
        {
            //criar uma nova lista de alunos reprovados
            var reprovados = new List<string>();

            for(int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if(aluno.Status == reprovado)
                {
                    reprovados.Add(aluno);
                }
            }
            return reprovados;
        }

        public List<string> ObterEmExame()
        {
            var exame = new List<string>();

            for(int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if(aluno.Status == AlunoStatus.EmExame)
                {
                    exame.Add(aluno.ObterStatus());
                }
            }

            return exame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var mediaAluno = 0.0;

            for(int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if(aluno.CodigoMatricula == codigoMatricula)
                {
                    mediaAluno = mediaAluno + aluno.CalcularMedia();
                }
            }

            return mediaAluno;
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            for(int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if(aluno.CodigoMatricula == codigoMatricula)
                {
                    return aluno;
                }
            }
            return null;
        }

        public double ObterMediaIdade()
        {
            var mediaIdades = 0;

            for(int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                mediaIdades = aluno.Idade / alunos.Count;
            }

            return mediaIdades;
        }

        public Aluno ObterAlunoPorMatricula(int codigoMatricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    return alunoAtual;
                }
            }
            return null;
        }
    }
}
