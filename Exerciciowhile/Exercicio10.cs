using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.WriteLine("Digite um numero inteiro qualquer: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            while(numeroDigitado > 0)
            {
                if(numeroDigitado % 2 == 0)
                {
                    Console.WriteLine(numeroDigitado);
                }
                if(numeroDigitado % 1 == 0)
                {
                    Console.WriteLine(numeroDigitado);
                }
                numeroDigitado = numeroDigitado - 50;
            }
            Console.WriteLine(numeroDigitado);
        }
    }
}
