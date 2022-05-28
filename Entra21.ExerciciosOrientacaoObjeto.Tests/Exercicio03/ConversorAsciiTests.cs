using Entra21.ExerciciosOrientacaoObjeto.Exercicio03;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjeto.Tests.Exercicio03
{
    public class ConversorAsciiTests
    {
        [Fact]
        public void Validar_CodigoAscii_A()
        {
            var codigo = new ConversorAscii();           
            codigo.Caracter = "A";

            var confirmarCodigoAscii = codigo.ObterCodigoAsciiDoCaracter();

            confirmarCodigoAscii.Should().Be(codigo.Caracter);
        }
    }
}