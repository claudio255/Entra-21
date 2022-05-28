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
            
            Console.WriteLine("Digite a letra que deseja: ");
            caracter = Console.ReadLine();

            Console.WriteLine(caracter.ObterCodigoAsciiDoCaracter());
        }

    }
}
