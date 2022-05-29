using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio04
{
    //    Criar uma classe chamada Farmácia com as seguintes propriedades:
    //● Razão social
    //● CNPJ
    //● Nome produto 1
    //● Preço produto 1
    //● Categoria produto 1
    //● Nome produto 2
    //● Preço produto 2
    //● Categoria produto 2
    //● Nome produto 3
    //● Preço produto 3
    //● Categoria produto 3

    //Criar métodos:

    //● Apresentar total do pedido
    //● Apresentar total do pedido por categoria de produto
    //Exemplo:
    //○ Antiinflamatório total 15,78
    //○ Antibiótico total 32.50
    //● Apresentar quantidade por categoria
    //● Apresentar nome do produto mais caro
    //● Apresentar nome e categoria do produto mais barato.

    //Obs.: Criar classe ExercicioFarmacia e testes unitários validando os métodos acima.
    public class Farmacia
    {
        public string RazaoSocial, Cnpj, NomeProduto1, CategoriaProduto1, NomeProduto2, CategoriaProduto2, NomeProduto3, CategoriaProduto3;
        public double PrecoProduto1, PrecoProduto2, PrecoProduto3;

        public double ApresentarTotalDoPedido()
        {
            var precoFinal = (PrecoProduto1 + PrecoProduto2 + PrecoProduto3);

            return precoFinal;
        }

            double totalPorCategoriaAntiflamatorio = 0.0;
        public double ApresentarTotalPedidoCategoriaAntiflamatorio()
        {

            if (CategoriaProduto1 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto1;
            }
            else if(CategoriaProduto2 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto2;
            }
            else if(CategoriaProduto3 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto3;
            }

            return totalPorCategoriaAntiflamatorio;
        }

            double totalPorCategoriaAntibiotico = 0.0;
        public double ApresentarPorCategoriaAntibiotico()
        {

            if(CategoriaProduto1 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto1);
            }
            else if(CategoriaProduto2 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto2);
            }
            else if(CategoriaProduto3 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto3);
            }

            return totalPorCategoriaAntibiotico;
        }

            double totalPorCategoriaAntidepressivo = 0.0;
        public double ApresentarPorCategoriaAntidepressivo()
        {

            if(CategoriaProduto1 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto1;
            }
            else if(CategoriaProduto2 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto2;
            }
            else if(CategoriaProduto3 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto3;
            }

            return totalPorCategoriaAntidepressivo;
        }

    }
}
