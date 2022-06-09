namespace ExemploProdutoLista
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        //Aramazenar o codigo do proximo produto
        private int codigoAtual = 1;

        //encapsulamento + tipoRetorno + NomeMetodo(parâmetro)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as Propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Adicionar o produto instanciando na lista de produtos
            produtos.Add(produto);
        }

        public void Editar() { }

        public bool Apagar(int codigo)
        {
            for(int i = 0; i < produtos.Count; i++)
            {
                //Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];

                //Resgatando de uma lista de tipos primitivos
                Produto produto = produtos[i];
                if(produto.Codigo == codigo)
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
            for(int i = 0; i < produtos.Count; i++)
            {
                //obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                //verifica se o produto atual da lista percorrida é o desejado
                if(produtoAtual.Codigo == codigo)
                {
                    //retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //retorna null, caso nao encontre um produto com o codigo passado como parâmetro
            return null;
        }
    }
}
