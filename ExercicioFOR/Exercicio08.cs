using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.WriteLine("Digite qualquer numero inteiro: ");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());

           

            for(int i = 0; i < 1000; i++)
            {
                i = i * numeroDigitado;

                Console.WriteLine(i);
            }
        }
    }
}
