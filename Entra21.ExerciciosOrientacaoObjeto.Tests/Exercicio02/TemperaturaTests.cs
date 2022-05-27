using Entra21.ExerciciosOrientacaoObjeto.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjeto.Tests.Exercicio02
{
    public class TemperaturaTests
    {
        [Fact]
        public void Validar_CalcularCelsius_Kelvin_Para_Celsius()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "kelvin";
            temperatura.TemperaturaDeDestino = "celsius";
            temperatura.TemperaturaValor = 300;
            

            var calcularKelvinParaCelsius = temperatura.CalcularCelsius();

            var resultadoCelsius = temperatura.TemperaturaValor - 273.15;
            calcularKelvinParaCelsius.Should().Be(resultadoCelsius);
        }
    }
}
