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
            DateTime dataHoje = DateTime.Now;
            var anoHoje = dataHoje.Year + 2;
            var quantidadeCarros = 0;
            while (quantidadeCarros <= 0)
            {
                try
                {
                    Console.WriteLine("Digite a quantidade de carros que deseja cadastrar: ");
                    quantidadeCarros = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite uma quantidade valida!");
                }
            }
            var modelo = ""; var valor = 0.0; var ano = 0; var mediaAno = 0; var mediaValor = 0.0; var quantidadeCarrosG = ""; var quantidadeCarrosA = "";
            var mediaAnoTotal = 0; var mediaValorTotal = 0.0;

            for (int i = 0; i < quantidadeCarros; i++)
            {
                while (modelo.Length < 2)
                {
                    Console.WriteLine("Digite o modelo do carro: ");
                    modelo = Console.ReadLine().Trim().ToLower();
                    if(modelo.Length < 2)
                    {
                        Console.WriteLine("O modelo inserido não é valido!");
                    }
                }
                if (modelo.StartsWith("g"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modelo.StartsWith("a"))
                {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }
                while (valor < 1000 || valor > 10000000)
                {
                    try
                    {
                        Console.WriteLine("Digite o valor do carro: ");
                        valor = Convert.ToDouble(Console.ReadLine());

                        if (valor < 1000)
                        {
                            Console.WriteLine("O valor digitado é menor que o minimo permitido!");
                        }
                        else if (valor > 10000000)
                        {
                            Console.WriteLine("O valor digitado é superior ao valor maximo permitido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O valor digitado não é valido!");
                    }
                }
                while (ano < 2000 || ano > anoHoje)
                {
                    try
                    {
                        Console.WriteLine("Digite o ano do carro: ");
                        ano = Convert.ToInt32(Console.ReadLine());

                        if (ano < 2000)
                        {
                            Console.WriteLine("O ano digitado é menor do que o minimo permitido!");
                        }
                        else if (ano > anoHoje)
                        {
                            Console.WriteLine("O ano é superior ao ano atual!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Por favor digite um ano valido!");
                    }
                }


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
