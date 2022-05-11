using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio12
    {
        public void Executar()
        {

            int produtoDesejado = 0; int quantidadeBolos = 0; int quantidadeDoces = 0; int quantidadeSanduiches = 0; int quantidadePizzas = 0;
            double valorTotal = 0;


            while (produtoDesejado != 9)
            {
                Console.WriteLine(@"--------------------MENU-------------------
1 - Bolo - Bolo de brigadeiro - R$29,50
2 - Bolo - Bolo Floresta negra - R$2,00
3 - Doce - Bomba de creme - R$17,71
4 - Doce - Bomba de morango - R$4,82
5 - Sanduiches - Filé-Mignon com fritas e cheddar - R$21,16
6 - Sanduiches - Provolone com salame - R$19,70
7 - Pizza - Calabresa - R$8,98
8 - Pizza - Peruana - R$18,36
9 - sair
Escolha quais produtos deseja: ");
                produtoDesejado = Convert.ToInt32(Console.ReadLine());
                if (produtoDesejado == 1)
                {
                    valorTotal = valorTotal + 29.50;
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if(produtoDesejado == 2)
                {
                    valorTotal = valorTotal + 2.00;
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if(produtoDesejado == 3)
                {
                    valorTotal = valorTotal + 17.71;
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if(produtoDesejado == 4)
                {
                    valorTotal = valorTotal + 4.82;
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if (produtoDesejado == 5)
                {
                    valorTotal = valorTotal + 21.16;
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if(produtoDesejado == 6)
                {
                    valorTotal = valorTotal + 19.70;
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if(produtoDesejado == 7)
                {
                    valorTotal = valorTotal + 8.98;
                    quantidadePizzas = quantidadePizzas + 1;
                }
                else if (produtoDesejado == 8)
                {
                    valorTotal = valorTotal + 18.36;
                    quantidadePizzas = quantidadePizzas + 1;
                }
                else
                {

                }
            }
            int quantidadeTotalProdutos = (quantidadeBolos + quantidadeDoces + quantidadeSanduiches + quantidadePizzas);
            double mediaTotal = valorTotal / quantidadeTotalProdutos;
            Console.WriteLine("A quantidade total de produtos foi de: " + quantidadeTotalProdutos);
            Console.WriteLine("A quantidade de bolos escolhidos foi de " + quantidadeBolos + " bolos");
            Console.WriteLine("A quantidade de doces escolhidos foi de " + quantidadeDoces + " doces");
            Console.WriteLine("A quantidade de sanduiches escolhidos foi de " + quantidadeSanduiches + " sanduiches");
            Console.WriteLine("A quantidade de pizzas escolhidas foi de " + quantidadePizzas + " pizzas");
            Console.WriteLine("O total do consumo ficou: " + valorTotal);
            Console.WriteLine("A media total foi de: " + mediaTotal);
        }
    }
}
