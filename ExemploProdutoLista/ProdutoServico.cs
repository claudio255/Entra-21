﻿namespace ExemploProdutoLista
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        //Armazenar o codigo do proximo produto
        private int codigoAtual = 1;

        //encapsulamento + tipoRetorno + NomeMetodo(parâmetro) => tudo isso chama-se ASSINATURA do METODO
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as Propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //atribuir o codigo novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no codigo atual para quando criar um novo produto o produto conter outro codigo;
            codigoAtual = codigoAtual + 1;

            //Adicionar o produto instanciando na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //obtem o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //verifica senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                //retorna falso pq nao exite produto com o codigo dos parâmetros
                return false;
            }

            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            //retorna verdadeiro pq foi possivel alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                //Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];

                //Resgatando de uma lista de tipos primitivos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //posso remover com o indice do objeto desejado
                    //produtos.RemoveAt(i);

                    //posso remover com o objeto desejado
                    produtos.Remove(produto);
                    //retorna verdeiraro pq o produto ou codigo desejado foi removido da lista
                    return true;
                }
            }
            //retorna falso pq o produto ou codigo desejado nao foi em contrado, ou seja, nenhum elemento foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {

            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percorrer todos os elementos para encontrar o produto
            //filtrar por codigo
            for (int i = 0; i < produtos.Count; i++)
            {
                //obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                //verifica se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //retorna null, caso nao encontre um produto com o codigo passado como parâmetro
            return null;
        }
        
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            for(int i = 0; i < produtos.Count; i++)
            {
                Produto produto = produtos[i];

                if(produto.PrecoUnitario < menorPrecoUnitario)
                {
                    menorPrecoUnitario = produto.PrecoUnitario;

                    produtoMenorPrecoUnitario = produto;
                }
            }
            return produtoMenorPrecoUnitario;
        }

        public List<double> ObtertodosPrecos()
        {
            var precos = new List<double>();

            for(int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }

        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                if(produto.Localizacao == localizacao)
                {
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public List<double> ObterPrecoTotaisDoArmazem()
        {
            var precos = new List<double>();

            for(int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                if(produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }

            return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;
            for(int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                somaPrecosTotais += produto.CalcularPrecoTotal();
            }

            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}
