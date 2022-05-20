using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[16];

            for(int i = 0; i < 16; i++)
            {
                try
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("O numero digitado não é valido para essa operação!");

                }
            }
            Console.Clear();

            int soma = 0;
            for (int i = 0; i < 16; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine(@$"A soma dos numeros resulta em: {soma}");
        }
    }
}
