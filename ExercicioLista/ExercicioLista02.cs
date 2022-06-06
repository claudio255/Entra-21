using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    public class ExercicioLista02
    {
        public void Executar()
        {
            //            2.Criar uma classe que irá armazenar os conteúdos passados até o momento:
            //            a.Adicionar o conteúdo "Como fazer um bolo"
            //b.Listar conteúdos
            //c.Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que
            //se alimentam”
            //d.Adicionar o conteúdo "variáveis"
            //e.Adicionar o conteúdo "Mais para frente"
            //f.Alterar o conteúdo “Mais para frente" por "If com E"
            //g.Adicionar o conteúdo "If com OU”;
            //h.Adicionar o conteúdo "While";
            //            i.Adicionar o conteúdo "For"
            //j.Listar conteúdos
            //k.Adicionar o conteúdo "Vetor"
            //l.Adicionar o conteúdo "Vetor”
            //m.Apagar os conteúdos "Vetor"
            //n.Adicionar o conteúdo "Vetor"
            //o.Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
            //p.Listar conteúdos
            //q.Adicionar o conteúdo "Classe propriedades e métodos"
            //r.Listar conteúdos

            List<string> exercicio02 = new List<string>();
            exercicio02.Add("Como fazer um bolo");
            Console.WriteLine(exercicio02[0]);

            exercicio02[0] = "Algoritmos onde vivem? Do que se alimentam?";
            exercicio02.Add("Variáveis");
            exercicio02.Add("Mais para frente");

            exercicio02[2] = "If com E";
            exercicio02.Add("If com OU");
            exercicio02.Add("While");
            exercicio02.Add("For");

            Console.WriteLine($@"
Algoritmos:
{exercicio02[0]}
{exercicio02[1]}
{exercicio02[2]}
{exercicio02[3]}
{exercicio02[4]}
{exercicio02[5]}");

            exercicio02.Add("Vetor");
            exercicio02.Add("Vetor");
            exercicio02.RemoveAt(6);
            exercicio02.RemoveAt(6);
            exercicio02.Add("vetor");
            exercicio02[6] = "Vetor com For um amor na minha vida";

            Console.WriteLine($@"
{exercicio02[0]}
{exercicio02[1]}
{exercicio02[2]}
{exercicio02[3]}
{exercicio02[4]}
{exercicio02[5]}
{exercicio02[6]}");

            exercicio02.Add("Classes, propriedades e metodos");

            Console.WriteLine($@"
{exercicio02[0]}
{exercicio02[1]}
{exercicio02[2]}
{exercicio02[3]}
{exercicio02[4]}
{exercicio02[5]}
{exercicio02[6]}
{exercicio02[7]}");
        }
    }
}
