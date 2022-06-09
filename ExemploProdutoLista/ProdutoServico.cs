namespace ExemploProdutoLista
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
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

        public void Apagar(int codigo)
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
                }
                
            }
        }

        public List<Produto> ObterTodos()
        {

            return produtos;
        }
        public Produto ObterPorCodigo()
        {

            return null;
        }
    }
}
