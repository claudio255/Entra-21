using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio04
{
    public class ExemploFarmacia
    {
        public void Executar()
        {
            var farmacia = new Farmacia();
            farmacia.NomeProduto1 = "respiridona";
            farmacia.CategoriaProduto1 = "antidepressivo";
            farmacia.PrecoProduto1 = 10.22;
            farmacia.NomeProduto2 = "ibuprofeno";
            farmacia.CategoriaProduto2 = "antibiotico";
            farmacia.PrecoProduto2 = 22.22;
            farmacia.NomeProduto3 = "remedio";
            farmacia.CategoriaProduto3 = "antiflamatorio";
            farmacia.PrecoProduto3 = 10.03;

            Console.WriteLine(@$"O valor total do pedido é {farmacia.ApresentarTotalDoPedido()}
O preço total dos antidepressivos é: {farmacia.ApresentarTotalPedidoCategoriaAntiflamatorio()}
O preço total dos antibioticos é: {farmacia.ApresentarPorCategoriaAntibiotico()}
O preço total dos antiflamatorios é: {farmacia.ApresentarPorCategoriaAntidepressivo()}
O produto mais barato é: {farmacia.ApresentarNomeCategoriaDoProdutoMaisBarato()}
O produto mais caro é: {farmacia.ApresentarNomeProdutoMaisCaro()}");
        }
    }
}
