using ExemploProdutoLista;

Console.WriteLine(@"----------MENU------------
1 - Produto");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if (opcaoEscolhida == 1)
{
    ProdutoControlador controlador = new ProdutoControlador();
    controlador.GerenciarMenu();
}

