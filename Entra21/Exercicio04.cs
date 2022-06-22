using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21
{
    internal class Exercicio04
    {
        public void Executar()
        {
            Console.WriteLine("Digite um numero que deseja: ");
            var numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            if(numeroEscolhido % 2 == 0)
            {
                Console.WriteLine("O numero escolhido é par!");
            }
            else
            {
                Console.WriteLine("O numero escolhido é impar");
            }
        }
    }
}
