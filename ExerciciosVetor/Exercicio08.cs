using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            int[] numeros = new int[10];

            for(int i = 0; i < numeros.Length; i++)
            {
                var numerosValidos = false;
                while(numerosValidos == false)
                {
                    try
                    {
                        Console.WriteLine("Digte o numero que deseja: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());

                        numerosValidos = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("O numero digitado não é valido!");
                    }
                    if(numeros[i] % 2 == 1)
                    {
                        Console.WriteLine("Por favor digite um numero par!");
                    }
                }
            }
                Console.WriteLine($"Os numeros pares digitados são: ")
        }
    }
}
