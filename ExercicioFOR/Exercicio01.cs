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
                var nome = "";
                var valor = 0.0;
                while (nome == "")
                {
                    Console.WriteLine("Digite o nome da peça: ");
                    nome = Console.ReadLine();
                    if(nome == "")
                    {
                        Console.WriteLine("Nome invalido!");
                    }
                }
                while(valor <= 0.0 )
                try
                {
                    Console.WriteLine("Digite o valor da peça: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Erro por favor digitar novamente!");
                }
            }
        }
    }
}
