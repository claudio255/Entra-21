using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio12
    {
        public void Executar()
        {
            int[] numeros = new int[5];
            int[] numerosCrescentes = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o numero que deseja: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();   
        }
    }
}