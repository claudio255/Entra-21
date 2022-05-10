using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string texto = "";
            string nome = "";
            while (nome != "fim")
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine().ToLower();
                texto = texto + nome + "\n";
            }

        }
    }
}
