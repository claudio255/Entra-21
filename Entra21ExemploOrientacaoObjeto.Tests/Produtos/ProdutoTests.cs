using Entra21ExemploOrientacaoObjeto.Produtos;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21ExemploOrientacaoObjeto.Tests.Produtos
{
    public class ProdutoTests
    {
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()


        {
            //ARRANGE -> preparar os dados
            var produto = new Produto();
            produto.DataVencimento = new DateTime(2022, 05, 04); //DateTime.Today.AddDays(-1);

            //ACT -> ato da execuçao do método que deseja testar
            var produtoVencido = produto.EhVencido();

            //ASSERT -> validação do que foi gerado
            produtoVencido.Should().BeTrue(); //poderia ser usado tambem -> produtoVencido.Should().Be(true);

        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1); //para colocar a data de hoje mais um dia, para nao ficar um teste engessado

            //Act
            var vencido = produto.EhVencido();

            //Assert
            vencido.Should().BeFalse(); //poderia ser usado vencido.Should().Be(false);
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //Act
            var vencido = produto.EhVencido();

            //Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            //Act
            var emPromocao = produto.EstaEmPromocao();

            //Assert
            emPromocao.Should().BeTrue();

        }

        [Fact]
        public void Valida_EstaEmPromocao_Falso()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //Act
            var emPromocao = produto.EstaEmPromocao();

            //Assert
            emPromocao.Should().BeFalse();
        }
    }
}
