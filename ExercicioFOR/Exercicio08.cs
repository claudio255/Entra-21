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
            var numeroDigitado = 0;
            while (numeroDigitado <= 0 || numeroDigitado > 1000)
            {
                try
                {
                    Console.WriteLine("Digite qualquer numero qualquer: ");
                    numeroDigitado = Convert.ToInt32(Console.ReadLine());
                    if(numeroDigitado <= 0)
                    {
                        Console.WriteLine("O numero digitado não pode ser menor ou igual a zero!");
                    }
                    else if(numeroDigitado > 1000)
                    {
                        Console.WriteLine("O numero digitado não pode ser superior a Mil");
                    }
                }
                catch
                {
                    Console.WriteLine("O numero digitado nao é valido, por favor digite novamente!");
                }
            }

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
