using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomesProdutos = new string[7];
            double[] valorProdutos = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite o nome do produto que deseja: ");
                nomesProdutos[i] = Console.ReadLine().Trim().ToLower();
                while (nomesProdutos[i].Length < 2 || nomesProdutos[i].Length > 40)
                {
                    Console.WriteLine(@"O nome do produto é menor do que a quantidade miníma de caracteres ou é maior que a quantidade maxíma de caracteres!
Por favor digite novamente: ");
                    nomesProdutos[i] = Console.ReadLine().Trim().ToLower();
                }
                try
                {
                    Console.WriteLine("Digite o valor do produto que deseja: ");
                    valorProdutos[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(@"O valor digitado não é valido!
Por favor digite o valor novamente: ");
                    valorProdutos[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($@"O produto desejado é: {nomesProdutos[i]} e o seu valor é: {valorProdutos[i]}");
            }
        }
    }
}
