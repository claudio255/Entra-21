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

            Console.WriteLine("Digite qualquer numero qualquer: ");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 1000; i++)
            {
                
                try
                {
                    i = i * numeroDigitado;

                    Console.WriteLine(i);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(@"O numero digitado nao é valido para essa operação! Por favor digite-o novamente);
Digite qualquer numero: ");
                    numeroDigitado = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
