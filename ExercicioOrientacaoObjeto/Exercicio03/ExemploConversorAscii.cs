using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio03
{
    public class ExemploConversorAscii
    {
        public void Executar()
        {
            var letraDigitada = new ConversorAscii();
            Console.WriteLine("Digite a letra que deseja: ");

            


            Console.WriteLine("O codigo ASCII correspondente a letra digitada é: " + letraDigitada.ObterCodigoAsciiDoCaracter());
        }

    }
}
