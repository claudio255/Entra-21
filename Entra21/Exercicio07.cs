using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21
{
    internal class Exercicio07
    {
        public void Executar()
        {
            Console.WriteLine("Digite o numero desejado: ");
            var numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            if (numeroEscolhido == 0)
                Console.WriteLine($"O numero digitado é neutro");
            if (numeroEscolhido % 2 == 0)
                Console.WriteLine("O numero digitado é par!");
            if (numeroEscolhido % 2 == 1)
                Console.WriteLine("O numero digitado é impar!");
            if (numeroEscolhido > 0)
                Console.WriteLine("o numero digitado é positivo!");
            if (numeroEscolhido < 0)
                Console.WriteLine("O numero digitado é negativo!");
            if (numeroEscolhido > 10)
                Console.WriteLine("O numero digitado é maior que dez!");
            if (numeroEscolhido <= 50)
                Console.WriteLine("O numero digitado é menor ou igual a cinquenta!");
            if (numeroEscolhido < -10)
                Console.WriteLine("O numero digitado é menor que menos dez!");
            if (numeroEscolhido >= 30)
                Console.WriteLine("O numero digitado é maior ou igual a trinta!");
            if (numeroEscolhido != 1)
                Console.WriteLine("o numero digitado é diferente de um!");
        }
    }
}
