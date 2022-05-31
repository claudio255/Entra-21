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

        public string ApresentarTotalPedidoCategoriaAntiflamatorio()
        {
            double totalPorCategoriaAntiflamatorio = 0.0;
            var quantidadeAntiflamatorio = 0;

            if (CategoriaProduto1 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto1;
                quantidadeAntiflamatorio = quantidadeAntiflamatorio + 1;
            }
            if (CategoriaProduto2 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto2;
                quantidadeAntiflamatorio = quantidadeAntiflamatorio + 1;
            }
            if (CategoriaProduto3 == "antiflamatorio")
            {
                totalPorCategoriaAntiflamatorio = totalPorCategoriaAntiflamatorio + PrecoProduto3;
                quantidadeAntiflamatorio = quantidadeAntiflamatorio + 1;
            }

            return totalPorCategoriaAntiflamatorio + "\nA quantidade de antiflamatorios adquiridos é: " + quantidadeAntiflamatorio;
        }

        public string ApresentarPorCategoriaAntibiotico()
        {
            double totalPorCategoriaAntibiotico = 0.0;
            var quantidadeAntibiotico = 0;

            if (CategoriaProduto1 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto1);
                quantidadeAntibiotico = quantidadeAntibiotico + 1;
            }
            if (CategoriaProduto2 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto2);
                quantidadeAntibiotico = quantidadeAntibiotico + 1;
            }
            if (CategoriaProduto3 == "antibiotico")
            {
                totalPorCategoriaAntibiotico = (totalPorCategoriaAntibiotico + PrecoProduto3);
                quantidadeAntibiotico = quantidadeAntibiotico + 1;
            }

            return totalPorCategoriaAntibiotico + "\nA quantidade de antibioticos adquiridas é: " + quantidadeAntibiotico;
        }


        public string ApresentarPorCategoriaAntidepressivo()
        {
            double totalPorCategoriaAntidepressivo = 0.0;
            var quantidadeAntidepressivo = 0;

            if (CategoriaProduto1 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto1;
                quantidadeAntidepressivo = quantidadeAntidepressivo + 1;
            }
            if (CategoriaProduto2 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto2;
                quantidadeAntidepressivo = quantidadeAntidepressivo + 1;
            }
            if (CategoriaProduto3 == "antidepressivo")
            {
                totalPorCategoriaAntidepressivo = totalPorCategoriaAntidepressivo + PrecoProduto3;
                quantidadeAntidepressivo = quantidadeAntidepressivo + 1;
            }

            return totalPorCategoriaAntidepressivo + "\nA quantidade de antidepressivos adqueridos é: " + quantidadeAntidepressivo;

        }

        public string ApresentarNomeCategoriaDoProdutoMaisBarato()
        {
            string menorNomeProduto = "";
            string nomeMenorCategoria = string.Empty;
            double menorValorProduto = double.MaxValue;
            if (PrecoProduto1 < menorValorProduto)
            {
                nomeMenorCategoria = CategoriaProduto1;
                menorNomeProduto = NomeProduto1;
            }
            if (PrecoProduto2 < menorValorProduto)
            {
                nomeMenorCategoria = CategoriaProduto2;
                menorNomeProduto = NomeProduto2;
            }
            if (PrecoProduto3 < menorValorProduto)
            {
                nomeMenorCategoria = CategoriaProduto3;
                menorNomeProduto = NomeProduto3;
            }

            return menorNomeProduto + " e a sua categoria é: " + nomeMenorCategoria;
        }

        public string ApresentarNomeProdutoMaisCaro()
        {
            var maiorValorProduto = 0;
            var nomeProdutoMaisCaro = string.Empty;
            if (PrecoProduto1 > maiorValorProduto)
            {
                nomeProdutoMaisCaro = NomeProduto1;
            }
            if (PrecoProduto2 > maiorValorProduto)
            {
                nomeProdutoMaisCaro = NomeProduto2;
            }
            if (PrecoProduto3 > maiorValorProduto)
            {
                nomeProdutoMaisCaro = NomeProduto3;
            }

            return nomeProdutoMaisCaro;
        }

    }
}
