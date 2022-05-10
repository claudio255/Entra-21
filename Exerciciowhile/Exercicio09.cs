using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            int resultado = 1;
            int numero = 0;

            while (numero != 1)
            {
                Console.WriteLine("Digite um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                resultado = resultado * numero;
                numero = numero - 1;
            }
            Console.WriteLine(resultado);
        }
    }
}
