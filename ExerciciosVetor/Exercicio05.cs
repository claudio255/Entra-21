using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];

            for (int i = 0; i < 5; i++)
            {
                bool pesoValido = false;
                while (pesoValido == false)
                {
                    try
                    {
                        Console.WriteLine("Digite o peso: ");
                        pesos[i] = Convert.ToDouble(Console.ReadLine());

                        pesoValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O peso digitado não é valido!");

                    }
                }
            }
            Console.Clear();

            double soma = 0;
            for(int i = 0; i < 5; i++)
            {
                soma = soma + pesos[i];
            }

            double mediaPesos = soma / 5;

            Console.WriteLine($@"A soma total dos pesos é de {soma} e a media total de pesos é de {mediaPesos}");

        }
    }
}
