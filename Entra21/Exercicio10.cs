using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.WriteLine("Digite o numero que deseja");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var terceiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var quartoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero == terceiroNumero && segundoNumero == quartoNumero)
                Console.WriteLine("Os numeros digitados formam um retangulo!");
            else
                Console.WriteLine("Os numero digitados não formam um retangulo!");
        }
    }
}
