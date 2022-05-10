using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nome = "";
            int indice = 0;
            int quantidadeProdutos = 0;
            int quantidadeTotal = 0;
            double valorProduto = 0;
            double valorTotalItens = 0;
            double valorTotalCompra = 0;
            double valorDesconto = 0;
            double valorTotalComDesconto = 0;
            


            while (nome != "sair")
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();
                while (nome != "sair")
                {
                    Console.WriteLine("Digite a quantidade de produtos que deseja: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor do produto desejado: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o nome do produto: ");
                    nome = Console.ReadLine();

                    
                    valorTotalItens = valorProduto * quantidadeProdutos;
                    valorTotalCompra = valorTotalCompra + valorTotalItens;

                    indice = indice + 1;
                }
                
                valorDesconto = valorTotalCompra * 0.05;
                valorTotalComDesconto = (valorTotalCompra - valorDesconto);
            }

            Console.WriteLine("O total da compra com desconto de 5% ficou: R$" + valorTotalComDesconto);
            


        }
    }
}
