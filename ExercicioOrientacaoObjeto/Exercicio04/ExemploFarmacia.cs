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
            farmacia.NomeProduto3 = "remedia";
            farmacia.CategoriaProduto3 = "antibiotico";
            farmacia.PrecoProduto3 = 10.03;

            Console.WriteLine(@$"O valor total do pedido é {farmacia.ApresentarTotalDoPedido()}
O preço total da categoria 1 é: {farmacia.ApresentarTotalPedidoCategoriaAntiflamatorio()}
O preço total da categoria 2 é: {farmacia.ApresentarPorCategoriaAntibiotico()}
O preço total da categoria 3 é: {farmacia.ApresentarPorCategoriaAntidepressivo()}");
        }
    }
}
