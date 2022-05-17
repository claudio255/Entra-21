using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.WriteLine("Digite um numero inteiro qualquer: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 50; numero > 0; numero = numero - 1)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }


            }


        }
    }
}
