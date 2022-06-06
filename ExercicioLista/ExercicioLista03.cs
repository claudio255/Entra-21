using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    public class ExercicioLista03
    {
        public void Executar()
        {
            //            Criar uma classe que irá as notas:
            //a.Solicitar a nota 1
            //b.Solicitar a nota 2
            //c.Solicitar a nota 3
            //d.Listar notas
            //e.Apresentar média das notas
            //f.Apresentar status da média

            List<double> notas = new List<double>();
            Console.WriteLine("Digite a sua primeira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a sua segunda nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a sua terceira nota: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($@"As notas digitada são: 
{notas[0]}  {notas[1]}  {notas[2]}");

            var mediaNotas = (notas[0] + notas[1] + notas[2]) / 3;

            Console.WriteLine("A media total do aluno é: " + mediaNotas);

            if (mediaNotas < 5)
            {
                Console.WriteLine("O aluno esta reprovado");
            }
            else if (mediaNotas >= 5 && mediaNotas < 7)
            {
                Console.WriteLine("O aluno esta em exame final");
            }
            else
            {
                Console.WriteLine("O aluno esta aprovado");
            }

        }
    }
}
