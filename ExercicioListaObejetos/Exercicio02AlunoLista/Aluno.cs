namespace ExercicioListaObejetos.Exercicio02AlunoLista
{
    internal class Aluno
    {
        public string Nome, MateriaFavorita;
        public int CodigoMatricula, Idade;
        public double Nota1, Nota2, Nota3;
        public AlunoStatus Status;

        public double CalcularMedia()
        {
            var mediaTotal = (Nota1 + Nota2 + Nota3) / 3;

            return mediaTotal;
        }

        public AlunoStatus ObterStatus()
        {
            if(CalcularMedia() >= 7)
            {
                return AlunoStatus.Aprovado;
            }
            else if(CalcularMedia() >= 5)
            {
                return AlunoStatus.EmExame;
            }
            else
            {
                return AlunoStatus.Reprovado;
            }
        }
    }
}


