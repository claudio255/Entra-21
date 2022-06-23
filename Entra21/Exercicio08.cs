namespace Entra21
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.WriteLine(@"------------MENU-----------
1 - Bolos - Bolo Brigadeiro R$ 29,50
2 - Bolos - Bolo Floresta Negra R$ 2,00
3 - Bolos - Bolo Leite com Nutella R$ 29,23
4 - Bolos - Bolo Mousse de Chocolate R$ 7,10
5 - Bolos - Bolo Nega Maluca R$ 19,33
6 - Doces - Bomba de Creme R$ 17,71
7 - Doces - Bomba de Morango R$ 4,82
8 - Sanduíches - Filé-Mignon com fritas e cheddar R$ 21,16
9 - Sanduíches - Hambúrguer com queijos,champignon e rúcula R$ 12,70
10 - Sanduíches - Provolone com salame R$ 19,70
11 - Sanduíches - Vegetariano de berinjela R$ 28,22
12 - Pizzas - Calabresa R$ 8,98
13 - Pizzas - Napolitana R$ 0,42
14 - Pizzas - Peruana R$ 18,36
15 - Pizzas - Portuguesa R$ 27,50
Escolha o primeiro produto que deseja: ");
            var primeiroPedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha o seu segundo pedido: ");
            var segundoPedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha o seu terceiro pedido: ");
            var terceiroPedido = Convert.ToInt32(Console.ReadLine());

            var total = 0.0;

            if (primeiroPedido == 1)
                total += 29.50;
            else if (primeiroPedido == 2)
                total += 2.00;
            else if (primeiroPedido == 3)
                total += 29.23;
            else if (primeiroPedido == 4)
                total += 7.10;
            else if (primeiroPedido == 5)
                total += 19.33;
            else if (primeiroPedido == 6)
                total += 17.71;
            else if (primeiroPedido == 7)
                total += 4.82;
            else if (primeiroPedido == 8)
                total += 21.16;
            else if (primeiroPedido == 9)
                total += 12.70;
            else if (primeiroPedido == 10)
                total += 19.70;
            else if (primeiroPedido == 11)
                total += 28.22;
            else if (primeiroPedido == 12)
                total += 8.98;
            else if (primeiroPedido == 13)
                total += 0.42;
            else if (primeiroPedido == 14)
                total += 18.36;
            else if (primeiroPedido == 15)
                total += 27.50;
            else { }



            if (segundoPedido == 1)
                total += 29.50;
            else if (segundoPedido == 2)
                total += 2.00;
            else if (segundoPedido == 3)
                total += 29.23;
            else if (segundoPedido == 4)
                total += 7.10;
            else if (segundoPedido == 5)
                total += 19.33;
            else if (segundoPedido == 6)
                total += 17.71;
            else if (segundoPedido == 7)
                total += 4.82;
            else if (segundoPedido == 8)
                total += 21.16;
            else if (segundoPedido == 9)
                total += 12.70;
            else if (segundoPedido == 10)
                total += 19.70;
            else if (segundoPedido == 11)
                total += 28.22;
            else if (segundoPedido == 12)
                total += 8.98;
            else if (segundoPedido == 13)
                total += 0.42;
            else if (segundoPedido == 14)
                total += 18.36;
            else if (segundoPedido == 15)
                total += 27.50;
            else { }


            if (terceiroPedido == 1)
                total += 29.50;
            else if (terceiroPedido == 2)
                total += 2.00;
            else if (terceiroPedido == 3)
                total += 29.23;
            else if (terceiroPedido == 4)
                total += 7.10;
            else if (terceiroPedido == 5)
                total += 19.33;
            else if (terceiroPedido == 6)
                total += 17.71;
            else if (terceiroPedido == 7)
                total += 4.82;
            else if (terceiroPedido == 8)
                total += 21.16;
            else if (terceiroPedido == 9)
                total += 12.70;
            else if (terceiroPedido == 10)
                total += 19.70;
            else if (terceiroPedido == 11)
                total += 28.22;
            else if (terceiroPedido == 12)
                total += 8.98;
            else if (terceiroPedido == 13)
                total += 0.42;
            else if (terceiroPedido == 14)
                total += 18.36;
            else if (terceiroPedido == 15)
                total += 27.50;
            else { }

            Console.WriteLine($"O total dos itens escolhidos são: {total}");
        }
    }
}
