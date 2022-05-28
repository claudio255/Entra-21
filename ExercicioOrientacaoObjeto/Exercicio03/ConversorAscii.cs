using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio03
{
    public class ConversorAscii
    {
        public string Caracter;

        public string ObterCodigoAsciiDoCaracter()
        {
            Console.WriteLine("Digite a letra que deseja: ");
            var letraDigitada = Console.ReadLine();

            if (letraDigitada.StartsWith("A"))
            {
                letraDigitada = "65";
            }
            else if (letraDigitada.StartsWith("B"))
            {
                letraDigitada = "66";
            }
            else if (letraDigitada.StartsWith("C"))
            {
                letraDigitada = "67";
            }
            else if (letraDigitada.StartsWith("D"))
            {
                letraDigitada = "68";
            }
            else if (letraDigitada.StartsWith("E"))
            {
                letraDigitada = "69";
            }
            else if (letraDigitada.StartsWith("F"))
            {
                letraDigitada = "70";
            }
            else if (letraDigitada.StartsWith("G"))
            {
                letraDigitada = "71";
            }
            else if (letraDigitada.StartsWith("H"))
            {
                letraDigitada =  "72";
            }
            else if (letraDigitada.StartsWith("I"))
            {
                letraDigitada = "73";
            }
            else if (letraDigitada.StartsWith("J"))
            {
                letraDigitada = "74";
            }
            else if (letraDigitada.StartsWith("K"))
            {
                letraDigitada = "75";
            }
            else if (letraDigitada.StartsWith("L"))
            {
                letraDigitada = "76";
            }
            else if (letraDigitada.StartsWith("M"))
            {
                letraDigitada = "77";
            }
            else if (letraDigitada.StartsWith("N"))
            {
                letraDigitada = "78";
            }
            else if (letraDigitada.StartsWith("O"))
            {
                letraDigitada = "79";
            }
            else if (letraDigitada.StartsWith("P"))
            {
                letraDigitada = "80";
            }
            else if (letraDigitada.StartsWith("Q"))
            {
                letraDigitada = "81";
            }
            else if (letraDigitada.StartsWith("R"))
            {
                letraDigitada = "82";
            }
            else if (letraDigitada.StartsWith("S"))
            {
                letraDigitada = "83";
            }
            else if (letraDigitada.StartsWith("T"))
            {
                letraDigitada = "84";
            }
            else if (letraDigitada.StartsWith("U"))
            {
                letraDigitada = "85";
            }
            else if (letraDigitada.StartsWith("V"))
            {
                letraDigitada = "86";
            }
            else if (letraDigitada.StartsWith("W"))
            {
                letraDigitada = "87";
            }
            else if (letraDigitada.StartsWith("Y"))
            {
                letraDigitada = "88";
            }
            else if (letraDigitada.StartsWith("Z"))
            {
                letraDigitada = "89";
            }
            return letraDigitada;
        }

    }
}
