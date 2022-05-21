using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            var nomeMaiorIdade = ""; var maiorIdade = 0.0;

            int[] idades = new int[9];

            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine("Digite o seu nome: ");
                var nome = Console.ReadLine();

                var idadeValida = false;
                while(idadeValida == false)
                try
                {
                    Console.WriteLine("Digite a idade: ");
                    idades[i] = Convert.ToInt32(Console.ReadLine());

                        idadeValida = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("A idade digitada não é valida!\nPor favor digite-a novamente: ");
                    
                }

                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    nomeMaiorIdade = nome;
                }
            }

            Console.WriteLine($"A pessoa com a maior idade é o(a) {nomeMaiorIdade} com uma idade de {maiorIdade} anos");
        }
    }
}
