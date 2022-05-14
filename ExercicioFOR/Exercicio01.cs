using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio01
    {
        public void Executar()
        {
            for(int i = 0; i < 13; i++)
            {
                try
                {
                    Console.WriteLine("Digite o nome da peça: ");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Digite o valor da peça: ");
                    var valor = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Erro por favor digitar novamente!!!!");
                }
            }
        }
    }
}
