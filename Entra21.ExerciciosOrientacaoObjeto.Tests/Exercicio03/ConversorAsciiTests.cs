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
        [Theory]
        [InlineData("A", 65)]
        [InlineData("B", 66)]
        public void Validar_CodigoAscii_A(string caracter, int letraDigitada)
        {
            var codigo = new ConversorAscii();
            codigo.Caracter = caracter;

            var confirmarCodigoAscii = codigo.ObterCodigoAsciiDoCaracter();

            confirmarCodigoAscii.Should().Be(letraDigitada);
            
        }

        //{
            //var codigo = new ConversorAscii();           
            //codigo.Caracter = "A";


            //var confirmarCodigoAscii = codigo.ObterCodigoAsciiDoCaracter();
            //var letraDigitada = 0;

            //if (codigo.Caracter.StartsWith("A"))
            //{
            //    letraDigitada = 65;

            //}

            //confirmarCodigoAscii.Should().Be(65);
        //}
    }
}