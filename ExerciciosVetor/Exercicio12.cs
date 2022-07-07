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
            Console.Clear();
            var quantidadeNumeros = 0;
            var quantidadeValida = false;

            while (quantidadeValida == false)
            {
                try
                {
                    Console.Write("Informe a quantidade de números que serão digitados: ");
                    quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeNumeros <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        quantidadeValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor informado não é valido. Por favor informe um número inteiro maior que zero.");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            var numeros = new double[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var numeroValido = false;

                while (numeroValido == false)
                {
                    try
                    {
                        Console.Write("Informe o número: ");
                        var numero = Convert.ToDouble(Console.ReadLine());

                        numeros[i] = numero;
                        numeroValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor informado não é valido. Por favor informe um número.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }

            var numerosOrdemCrescente = new double[quantidadeNumeros];

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                var contador = 0;
                for (var j = 0; j < quantidadeNumeros; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        contador++;
                    }
                }

                numerosOrdemCrescente[contador] = numeros[i];

            }

            for (var i = 0; i < quantidadeNumeros; i++)
            {
                if (numerosOrdemCrescente[i] == 0)
                {
                    numerosOrdemCrescente[i] = numerosOrdemCrescente[i - 1];
                }
            }
        }
    }
}