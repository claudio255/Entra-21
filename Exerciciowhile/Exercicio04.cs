using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double peso = 0;
            int indice = 0;

            while ((peso <= 300) && (peso >= 0))
            {
                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
            }
            Console.WriteLine("A quantidade de pessoas cadastradas foi: " + indice);
        }
    }
}
