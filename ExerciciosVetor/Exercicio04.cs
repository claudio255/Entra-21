using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double[] notas = new double[4];

            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    Console.WriteLine("Digite as suas notas: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(@"Essa nota não pode ser aceita!
Por favor digite novamente a nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                if (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("A nota digitada é inferior a zero ou superior a dez!\nPor favor digite-a novamente: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();

            double mediaNotas = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            Console.WriteLine($@"A media do aluno {nome} é {mediaNotas}");
        }
    }
}
