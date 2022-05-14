using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio05
    {
        public void Executar()
        {
            Console.WriteLine("Digite a quantidade de carros que deseja cadastrar: ");
            var quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            var modelo = ""; var valor = 0.0; var ano = 0; var mediaAno = 0; var mediaValor = 0.0; var quantidadeCarrosG = ""; var quantidadeCarrosA = "";
            var mediaAnoTotal = 0; var mediaValorTotal = 0.0;

            for(int i = 0; i < quantidadeCarros; i++)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                modelo = Console.ReadLine().Trim().ToLower();
                if(modelo.StartsWith("g"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if(modelo.StartsWith("a"))
                {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }
                Console.WriteLine("Digite o valor do carro: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o ano do carro: ");
                ano = Convert.ToInt32(Console.ReadLine());

                mediaAno = ano * quantidadeCarros;
                mediaAnoTotal = mediaAno / quantidadeCarros;
                mediaValor = valor * quantidadeCarros;
                mediaValorTotal = mediaValor / quantidadeCarros;


            }
            Console.WriteLine("A media de ano dos carros é de: " + mediaAnoTotal + " anos");
            Console.WriteLine("A media de valor dos carros é de: " + mediaValorTotal + " reais");
            Console.WriteLine("A quantidade de carros que começam com a letra G é de: " + quantidadeCarrosG + " carros");
            Console.WriteLine("A quantidade de carros que começam com a letra A é de: " + quantidadeCarrosA + " carros");
        }
    }
}
