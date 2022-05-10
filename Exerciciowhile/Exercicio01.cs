using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 0;

            while (indice < 13)
            {
                Console.WriteLine("Digite o nome da peça: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o valor da peça: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;

            }
        }
    }
}
