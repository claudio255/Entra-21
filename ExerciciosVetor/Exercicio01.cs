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
                Console.WriteLine("Digite um numero inteiro: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
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
