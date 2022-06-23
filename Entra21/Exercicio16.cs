using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21
{
    internal class Exercicio16
    {
        public void Executar()
        {
            //            Faça um sistema que realize a conversão da temperatura, solicite os seguintes
            //dados:
            //● Temperatura;
            //● Escala da temperatura de origem;
            //● Escala da temperatura de destino;
            //            Opções de origem e destino:
            //            Celsius,Fahrenheit e Kelvin
            Console.WriteLine("digite a temperatura que deseja: ");
            var temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a temperatura de origem (só a inicial): ");
            var temperaturaOrigem = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Digite a temperatura de destino (só a inical): ");
            var temperaturaDestino = Console.ReadLine().Trim().ToLower();

            if(temperaturaOrigem == "c" && temperaturaDestino == "k")
            {
                var temperaturaFinal = (temperatura + 273.15);
                Console.WriteLine("A temperatura em Kelvin é " + temperaturaFinal);
            }
            else if (temperaturaOrigem == "c" && temperaturaDestino == "f")
            {
                var temperaturaFinal = (temperatura * 1.8) + 32;
                Console.WriteLine("A temperatura em fahrenheit é " + temperaturaFinal);
            } 
            else if(temperaturaOrigem == "k" && temperaturaDestino == "c")
            {
                var temperaturaFinal = (temperatura - 273.15);
                Console.WriteLine("A temperatura em celsius é " + temperaturaFinal);
            }
            else if(temperaturaOrigem == "k" && temperaturaDestino == "f")
            {
                var temperaturaFinal = (temperatura - 273.15) * 1.8 + 32;
                Console.WriteLine("A temperatura em fahrenheit é " + temperaturaFinal);
            }
            else if (temperaturaOrigem == "f" && temperaturaDestino == "c")
            {
                var temperaturaFinal = (temperatura - 32) * 5/9;
                Console.WriteLine("A temperatura em celsius é " + temperaturaFinal);
            }
            else if (temperaturaOrigem == "f" && temperaturaDestino == "k")
            {
                var temperaturaFinal = (temperatura - 32) * 5 / 9 + 273.15;
                Console.WriteLine("A temperatura em kelvin é " + temperaturaFinal);
            }
        }
    }
}
