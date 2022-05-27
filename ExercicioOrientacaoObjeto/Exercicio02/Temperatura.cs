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

        public double CalcularCelsius()
        {
            var temperaturaFinal = 0.0;
            if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "celsius")
            {
                temperaturaFinal = (TemperaturaValor - 32) * 1.8;
            }
            else if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "celsius")
            {
                temperaturaFinal = TemperaturaValor - 273.15;
            }


            return temperaturaFinal;
        }

        public double CalcularKelvin()
        {
            var temperaturaFinal = 0.0;

            if(TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "kelvin")
            {
                temperaturaFinal = TemperaturaValor + 273.15;
            }
            else if(TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "kelvin")
            {
                temperaturaFinal = (TemperaturaValor - 32) * 5 / 9 + 273.15;
            }//(300 °F − 32) × 5/9 + 273,15

            return temperaturaFinal;
        }

        public double CalcularFahrenheit()
        {
            var temperaturaFinal = 0.0;

            if(TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "fahrenheit")
            {
                temperaturaFinal = (TemperaturaValor - 273.15) * 9 / 5 + 32;
            }
            else if(TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "fahrenheit")
            {
                temperaturaFinal = (TemperaturaValor * 1.8) + 32;
            }

            return temperaturaFinal;
        }

    }
}
