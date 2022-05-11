using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            Console.WriteLine("Digite o primeiro numero que deseja: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero desejado: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());



            int alternativaEscolhida = 0;

            while (alternativaEscolhida != 5)
            {
                Console.WriteLine(@"Escolha uma opeção aritmetica
1 - somar
2 - subtração
3 - multiplicar
4 - dividir
5 - sair");
                alternativaEscolhida = Convert.ToInt32(Console.ReadLine());
                if (alternativaEscolhida == 1)
                {
                    Console.WriteLine("A soma dos numeros " + numero1 + " + " + numero2 + " resultam em: " + (numero1 + numero2));
                }
                else if (alternativaEscolhida == 2)
                {
                    Console.WriteLine("A subtração dos numeros " + numero1 + " - " + numero2 + " resultam em: " + (numero1 - numero2));
                }
                else if (alternativaEscolhida == 3)
                {
                    Console.WriteLine("A multiplicação dos numeros " + numero1 + " * " + numero2 + " resultam em: " + numero1 * numero2);
                }
                else if (alternativaEscolhida == 4)
                {
                    Console.WriteLine("A divisao dos numeros: " + numero1 + " / " + numero2 + " resultam em: " + numero1 / numero2);
                }
                else
                {

                }
            }

        }
    }
} 
