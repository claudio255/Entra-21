using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21
{
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.WriteLine("Digite o numero que deseja: ");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if(numeroDigitado != 1)
            {
                Console.WriteLine("O numero digitado é diferente de um!");
            }
            else
            {
                Console.WriteLine("O numero digitado é um!");
            }
        }
    }
}
