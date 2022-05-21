using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            double[] altura = new double[4];

            var nomeMenorAnimal = ""; var menorAltura = double.MaxValue;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do animal: ");
                var nomeAnimal = Console.ReadLine();

                var alturaValida = false;
                while (alturaValida == false)
                {
                    try
                    {
                        Console.WriteLine("Digite a altura do animal: ");
                        altura[i] = Convert.ToDouble(Console.ReadLine());

                        alturaValida = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A altura do animal não é valida!");
                    }
                }
                if(altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                    nomeMenorAnimal = nomeAnimal;
                }
            }
            Console.Clear();

            Console.WriteLine($"O animal com a menor altura é o(a) {nomeMenorAnimal} com uma altura de {menorAltura}");
        }
    }
}
