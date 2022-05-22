using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int[] numeros = new int[10];
            int[] numerosPares = new int[10];
            int[] numerosImpares = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o numero que deseja: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                //foreach
                if (numeros[i] % 2 == 0)
                {
                    numerosPares[i] = numeros[i];
                }
                else
                {
                    numerosImpares[i] = numeros[i];
                }
            }
         
            Console.WriteLine($@"Os numeros pares são: {numerosPares[0]} {numerosPares[1]} {numerosPares[2]} {numerosPares[3]} {numerosPares[4]} {numerosPares[5]} {numerosPares[6]} {numerosPares[7]} {numerosPares[8]} {numerosPares[9]} 
E os numeros impoares são: {numerosImpares[0]} {numerosImpares[1]} {numerosImpares[2]} {numerosImpares[3]} {numerosImpares[4]} {numerosImpares[5]} {numerosImpares[6]} {numerosImpares[7]} {numerosImpares[8]} {numerosImpares[9]}");
        }
    }
}
//Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar
//somente os números pares do vetor 1, o outro irá armazenar somente os números ímpares
//do vetor 1.