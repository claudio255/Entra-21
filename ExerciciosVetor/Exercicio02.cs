using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[10];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome que deseja: ");
                nomes[i] = Console.ReadLine().Trim().ToLower();

                while (nomes[i].Length < 3 || nomes[i].Length > 30)
                {
                    Console.WriteLine(@"O nome não pode ter menos que três caracteres ou mais que trinta!
Por favor digite o nome novamente: ");
                    nomes[i] = Console.ReadLine().Trim().ToLower();
                }
            }
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
