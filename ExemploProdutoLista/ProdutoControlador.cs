using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploProdutoLista
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            //Repete enquanto o codigo nao for menu sair(6)
            while(codigo != 6)
            {
                Console.Clear();
                //apresentar o menu e solicitar o codigo
                codigo = ApresentarSolicitarMenu();

                if(codigo == 1)
                {
                    //menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if(codigo == 2)
                {
                    //Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if(codigo == 3)
                {
                    //Menu escolhido para editar produto
                    //Editar();
                }
                else if (codigo == 4)
                {
                    //Menu escolhido para apgar produto
                    //Apagar();
                }
                else if(codigo == 5)
                {
                    //Menu escolhido para apresentar produto
                    //ApresentarProduto();
                }
                Thread.Sleep(1000);
            }

        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"---------MENU---------
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            //Continua solicitando codigo ate que seja um codigo entre 1 e 6
            while(codigo < 1 || codigo >= 6)
            {
                try
                {
                    Console.WriteLine("Digite o codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu valido!");
                }
            }
            return codigo;
        }

        private void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço unitario: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }

        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtosAtual = produtos[i];

                Console.WriteLine("Nome: " + produtosAtual.Nome + "\nPreço unitario: " + produtosAtual.PrecoUnitario);

            }
        }
    }
}
