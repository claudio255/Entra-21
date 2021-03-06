using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    //    2. Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
    //● temperatura de origem
    //● Temperatura de destino
    //● Temperatura

    //Criar métodos:
    //● Calcular Celsius
    //● Calcular Kelvin
    //● Calcular Fahrenheit
    public class Temperatura
    {
        public string TemperaturaDeOrigem, TemperaturaDeDestino;
        public double TemperaturaValor;

        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (TemperaturaValor - 32) * 1.8;

            return temperaturaFinal;
        }

        public double CalcularKelvinParaCelsius()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = TemperaturaValor - 273.15;

            return temperaturaFinal;
        }
        public double CalcularCelsiusParaKelvin()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = TemperaturaValor + 273.15;

            return temperaturaFinal;
        }
        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (TemperaturaValor - 32) * 5 / 9 + 273.15;

            return temperaturaFinal;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (TemperaturaValor - 273.15) * 9 / 5 + 32;

            return temperaturaFinal;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (TemperaturaValor * 1.8) + 32;

            return temperaturaFinal;
        }

        public double ApresentarTemperaturaConvertida()
        {
            var temperaturaConvertida = 0.0;

            if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "celsius")
            {
                temperaturaConvertida = CalcularKelvinParaCelsius();
            }  
            else if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "celsius")
            {  
                temperaturaConvertida =  CalcularFahrenheitParaCelsius();
            }  
            else if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "kelvin")
            {  
               temperaturaConvertida = CalcularCelsiusParaKelvin();
            }
            else if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "kelvin")
            {
               temperaturaConvertida = CalcularFahrenheitParaKelvin();
            }
            else if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "fahrenheit")
            {
               temperaturaConvertida = CalcularCelsiusParaFahrenheit();
            }
            else if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "fahrenheit")
            {
               temperaturaConvertida = CalcularKelvinParaFahrenheit();
            }

            return temperaturaConvertida;
        }
    }
}
