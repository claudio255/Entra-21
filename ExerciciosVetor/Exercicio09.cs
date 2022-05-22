using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio09
    {
        public void Executar()
        {
            string[] nomes = new string[5];
            string[] nomes2 = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome desejado: ");
                nomes[i] = Console.ReadLine();

                
               
            }
            Console.Clear();

            for (int i = 0; i < nomes2.Length; i++)
            {
                nomes2[i] = nomes[4 - i];
            }


            Console.WriteLine($"{nomes2[0]} {nomes2[1]} {nomes2[2]} {nomes2[3]} {nomes2[4]}");
        }
    }
}
// Criar dois vetores, no primeiro solicite os nomes para o usuário