using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            int tabuada = 0;
            int numeroDesejado = 0;
            int indice = 0;
            int valorExatoTabuada = 0;

            while (indice < 10)
            {
                Console.Write("Digite o numero que deseja: ");
                numeroDesejado = Convert.ToInt32(Console.ReadLine());


                indice = indice + 1;
                tabuada = indice * numeroDesejado;
                Console.WriteLine(tabuada);

            }

           
        }
    }
}
