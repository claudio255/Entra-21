using Entra21.ExerciciosOrientacaoObjeto.Exercicio04;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjeto.Tests.Exercicio04
{
    public class FarmaciaTests
    {
        [Fact]
        public void Validar_ApresentarTotalPedido()
        {
            var preco = new Farmacia();
            preco.PrecoProduto1 = 20;
            preco.PrecoProduto2 = 30;
            preco.PrecoProduto3 = 50;

            var precoTotalProdutos = preco.ApresentarTotalDoPedido();
            var calcularTotalDosProdutos = (preco.PrecoProduto1 + preco.PrecoProduto2 + preco.PrecoProduto3);

            precoTotalProdutos.Should().Be(100);

        }

        [Fact]
        public void ApresentarTotalPedidoCategoriaAntiflamatorio()
        {
            var totalCategoriaAntiflamatorio = new Farmacia();
            totalCategoriaAntiflamatorio.CategoriaProduto1 = "antiflamatorio";
            totalCategoriaAntiflamatorio.PrecoProduto1 = 20;
            
        }

    }
}
