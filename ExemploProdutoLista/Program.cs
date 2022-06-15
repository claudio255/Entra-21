using ExemploProdutoLista;

Console.WriteLine(@"----------MENU------------
1 - Produto
2 - Aluno");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if(opcaoEscolhida == 1)
{
ProdutoControlador controlador = new ProdutoControlador();
controlador.GerenciarMenu();
}

//if(opcaoEscolhida == 2)
//{
//    AlunoControler aluno = new AlunoControler();
//    aluno.GerenciarMenu();
//}