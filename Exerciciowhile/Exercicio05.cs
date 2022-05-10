using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            int indice = 0; int mediaAno = 0; double mediaValor = 0;  int quantidadeCarrosG = 0; int quantidadeCarrosA = 0; string modeloCarro = ""; int anoCarro = 0; double valorCarro = 0;
            int mediaTotalAno = 0; double mediaTotalValor = 0;

            while (indice < quantidadeCarros)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                modeloCarro = Console.ReadLine();
                if (modeloCarro.StartsWith("g"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("a"))
                {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }
                Console.WriteLine("Digite o ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());

           

                mediaAno = anoCarro * quantidadeCarros;
                mediaTotalAno = mediaAno / quantidadeCarros;

                mediaValor = valorCarro * quantidadeCarros;
                mediaTotalValor = mediaValor / quantidadeCarros;

                indice = indice + 1;
            }
          
            Console.WriteLine("A media de ano dos carros é: " + mediaTotalAno);
            Console.WriteLine("A media de valor dos carros é: " + mediaTotalValor);
            Console.WriteLine("A quantidade de carros que começam com a letra G é: " + quantidadeCarrosG);
            Console.WriteLine("A quantidade de carros que começam com a letra A é: " + quantidadeCarrosA); 
           
            
            
            
        }
    }
}
