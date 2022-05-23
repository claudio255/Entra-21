using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            int[] numeros = new int[8];
            int[] somaNumerosVetor1 = new int[8];

            for (int i = 0; i < numeros.Length; i++)
            {
                var numerosValidos = false;
                while (numerosValidos == false)
                {
                    try
                    {
                        Console.WriteLine("Digite o numero que deseja: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());

                        numerosValidos = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O numero digitado não é valido para essa operação!");
                    }
                    if (numeros[i] < 0)
                    {
                        Console.WriteLine("O numero digitado não pode ser um negativo!");
                    }
                }
            }

            for (int i = 0; i < somaNumerosVetor1.Length; i++)
            {
                somaNumerosVetor1[i] = numeros[i] + numeros[7 - i];
            }
            for(int i = 0; i < somaNumerosVetor1.Length; i++)
            {
                Console.Write(somaNumerosVetor1[i] + "-");
            }
        }
    }
}
