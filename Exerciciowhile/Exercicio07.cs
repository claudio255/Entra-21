using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            int quantidade = 0;
            int quantidadeProdutos = 0;
            int valorDesconto = 150;
            double valor = 0;
            double valorTotalItens = 0; 
            double valorTotal = 0;
            double valorComDesconto = 0;
            string nome = "";

            while (quantidade < 5)
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade do produto: ");
                quantidadeProdutos = Convert.ToInt32(Console.ReadLine());


                valorTotalItens = valor * quantidadeProdutos;
                valorTotal = valorTotal + valorTotalItens;
                quantidade = quantidade + quantidadeProdutos;
            }
            valorComDesconto = valorTotal - valorDesconto;
            
            
            Console.WriteLine("O total da compra com desconto foi de: " + valorComDesconto);
        }
    }
}
