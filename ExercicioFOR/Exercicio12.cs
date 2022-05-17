using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio12
    {
        public void Executar()
        {
            var produtosDesejados = 0; var quantidadeBolos = 0; var quantidadeDoces = 0; var quantidadeSanduiches = 0; var quantidadePizzas = 0;
            var valorTotal = 0.0; var produtosConsumidos = 0; var mediaProdutos = 0.0;

            Console.WriteLine(@"-------------CARDAPÍO---------------
1 - Bolo - Bolo de brigadeiro - R$29,50
2 - Bolo - Nega maluca - R$19,33
3 - Bolo - Formigueiro - R$29,23
4 - Doce - Bomba de morango - R$4,82
5 - Doce - Bomba de chocolate - R$2,00
6 - Doce - Bomba de creme - R$17,71
7 - Sanduiche - Filé-Mignon com fritas e cheddar - R$21,16 
8 - Sanduiche - Salame com provolone - R$19,70
9 - Sanduiche - Vegetariano de beringela - R$28,22
10 - Pizza - Calabresa - R$8,98
11 - Pizza - Peruana - R$18,36
12 - Pizza - Napolitana - R$0,42
13 - Sair
Escolha os produtos que deseja e quando quiser sair digite 13: ");
            for (int i = 0; produtosDesejados != 13; i++)
            {

                produtosDesejados = Convert.ToInt32(Console.ReadLine());


                if (produtosDesejados == 1)
                {
                    valorTotal = valorTotal + 29.50;
                    quantidadeBolos = quantidadeBolos + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 2)
                {
                    valorTotal = valorTotal + 19.33;
                    quantidadeBolos = quantidadeBolos + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 3)
                {
                    quantidadeBolos = quantidadeBolos + 1;
                    valorTotal = valorTotal + 29.23;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 4)
                {
                    valorTotal = valorTotal + 4.82;
                    quantidadeDoces = quantidadeDoces + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 5)
                {
                    valorTotal = valorTotal + 2.00;
                    quantidadeDoces = quantidadeDoces + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 6)
                {
                    valorTotal = valorTotal + 17.71;
                    quantidadeDoces = quantidadeDoces + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 7)
                {
                    valorTotal = valorTotal + 21.16;
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 8)
                {
                    valorTotal = valorTotal + 19.70;
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 9)
                {
                    valorTotal = valorTotal + 28.22;
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 10)
                {
                    valorTotal = valorTotal + 8.98;
                    quantidadePizzas = quantidadePizzas + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 11)
                {
                    valorTotal = valorTotal + 18.36;
                    quantidadePizzas = quantidadePizzas + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else if (produtosDesejados == 12)
                {
                    valorTotal = valorTotal + 0.42;
                    quantidadePizzas = quantidadePizzas + 1;
                    produtosConsumidos = produtosConsumidos + 1;
                }
                else
                {

                }

            }
            mediaProdutos = valorTotal / produtosConsumidos;
            Console.WriteLine("O total de produtos escolhidos foi de: " + produtosConsumidos + " produtos");
            Console.WriteLine("Sendo " + quantidadeBolos + " bolos; " + quantidadeDoces + " doces; " + quantidadeSanduiches + " sanduiches; " + quantidadePizzas + " pizzas");
            Console.WriteLine("O valor total foi de R$" + valorTotal);
            Console.WriteLine("A media de valores foi de R$" + mediaProdutos);
        }
    }
}
