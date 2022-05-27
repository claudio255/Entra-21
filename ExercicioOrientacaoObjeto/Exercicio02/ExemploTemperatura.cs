using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperatura();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.TemperaturaValor = 300;

            ;
            Console.WriteLine($"A temperatura convertida é: {temperatura.ApresentarTemperaturaConvertida()}");
        }
    }
}
