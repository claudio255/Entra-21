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
            

            var calcularKelvinParaCelsius = temperatura.CalcularKelvinParaCelsius();

            var conversaoParaCelsius = temperatura.TemperaturaValor - 273.15;
            calcularKelvinParaCelsius.Should().Be(conversaoParaCelsius);
        }

        [Fact]
        public void Validar_CalcularCelsius_Fahrenheit_Para_Celsius()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "fahrenheit";
            temperatura.TemperaturaDeDestino = "celsius";
            temperatura.TemperaturaValor = 300;

            var calcularFahrenheitParaCelsius = temperatura.CalcularFahrenheitParaCelsius();

            var conversaoParaCelsius = (temperatura.TemperaturaValor - 32) * 1.8;
            calcularFahrenheitParaCelsius.Should().Be(conversaoParaCelsius);
        }

        [Fact]
        public void Validar_CalcularKelvin_Celsius_Para_Kelvin()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "kelvin";
            temperatura.TemperaturaValor = 300;

            var calcularCelsiusParaKelvin = temperatura.CalcularCelsiusParaKelvin();

            var conversaoParaKelvin = temperatura.TemperaturaValor + 273.15;
            calcularCelsiusParaKelvin.Should().Be(conversaoParaKelvin);
        }

        [Fact]
        public void Validar_CalcularKelvin_Fahrenheit_Para_Kelvin()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "fahrenheit";
            temperatura.TemperaturaDeDestino = "kelvin";
            temperatura.TemperaturaValor = 300;

            var calcularFahrenheitParaKelvin = temperatura.CalcularFahrenheitParaKelvin();

            var conversaoParaKelvin = (temperatura.TemperaturaValor - 32) * 5 / 9 + 273.15;
            calcularFahrenheitParaKelvin.Should().Be(conversaoParaKelvin);
        }

        [Fact]
        public void Validar_CalcularFahrenheit_Celsius_Para_Fahrenheit()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.TemperaturaValor = 300;

            var calcularCelsiusParaFahrenheit = temperatura.CalcularCelsiusParaFahrenheit();

            var conversaoParaFahrenheit = (temperatura.TemperaturaValor * 1.8) + 32;
            calcularCelsiusParaFahrenheit.Should().Be(conversaoParaFahrenheit);
        }

        [Fact]
        public void Validar_CalcularFahrenheit_Kelvin_Para_Fahrenheit()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "kelvin";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.TemperaturaValor = 300;

            var calcularKelvinParaFahrenheit = temperatura.CalcularKelvinParaFahrenheit();

            var conversaoParaFahrenheit = (temperatura.TemperaturaValor - 273.15) * 9 / 5 + 32;
            calcularKelvinParaFahrenheit.Should().Be(conversaoParaFahrenheit);
        }
    }
}
