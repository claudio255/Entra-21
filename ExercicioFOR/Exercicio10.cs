using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio10
    {
        public void Executar()
        {
            var numeroString = true;
            var numero = 0;
            while (numeroString == true)
            {
                try
                {
                    Console.WriteLine("Digite um numero inteiro qualquer: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    numeroString = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O numero digitado nao é valido!");
                    numeroString = true;
                }
            }
            var ordemDecrescente = numero;
            Console.WriteLine(@"
Os 50 numeros antecessores pares: 
");
            for (int i = 0; i < 50; i++)
            {
                ordemDecrescente = ordemDecrescente - 1;
                if (ordemDecrescente % 2 == 0)
                {
                    Console.WriteLine(ordemDecrescente);

                }
            }
            var ordemCrescente = numero;
            Console.WriteLine(@"
Os 50 numeros sucessores impares são:
");
            for(int i = 0; i < 50; i++)
            {
                ordemCrescente = ordemCrescente + 1;
                if(ordemCrescente % 2 != 0)
                {
                    Console.WriteLine(ordemCrescente);
                }
            }
        }
    }
}
