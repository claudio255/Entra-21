using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int idade = 0;

            while (idade < 129)
            {
                Console.WriteLine("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
