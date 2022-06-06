using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    public class ExercicioLista01
    {
        public void Executar()
        {
            //            Criar uma classe que irá armazenar os melhores filmes de todos os tempos.
            //a.Adicionar o filme "Dragon Ball Evollution";
            //            b.Adicionar o filme "Titanic";
            //            c.Adicionar o filme "Lanterna verde";
            //            d.Listar os filmes armazenados na lista;
            //            e.Adicionar o filme "";
            //            f.Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
            //            g.Remover filme "Lanterna verde";
            //            h.Verificar se a lista contém o filme "Lanterna verde" apresentando para o
            //           usuário se está ou não cadastrado;
            //            i.Adicionar o filme "Quarteto fantástico";
            //            j.Listar os filmes armazenados na lista;
            //            k.Alterar o filme "Titanic" para “Titanic 2”;
            //            l.Listar os filmes armazenados na lista;
            //            m.Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário
            List<string> melhoresFilmesDeTodosOsTempos = new List<string>();
            melhoresFilmesDeTodosOsTempos.Add("Dragon Ball Evollution");
            melhoresFilmesDeTodosOsTempos.Add("Titanic");
            melhoresFilmesDeTodosOsTempos.Add("Lanterna Verde");

            Console.WriteLine($@"Melhores filmes de todos os tempos:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}");

            melhoresFilmesDeTodosOsTempos.Insert(3, "");
            melhoresFilmesDeTodosOsTempos[0] = "Dragon Ball Super: Broly";
            melhoresFilmesDeTodosOsTempos.Remove("Lanterna Verde");
            var contemFilmeLanternaVerde = melhoresFilmesDeTodosOsTempos.Contains("Lanterna Verde");
            melhoresFilmesDeTodosOsTempos.Insert(3, "Quarteto Fantastico");

            Console.WriteLine($@"
Os melhores filmes de todos os tempos atulizados são:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}
{melhoresFilmesDeTodosOsTempos[3]}
O filme Lanterna Verde contem ou não na lista? {contemFilmeLanternaVerde}");

            melhoresFilmesDeTodosOsTempos[1] = "Titanic 2";

            Console.WriteLine($@"
Os melhores filmes de todos os tempos 2032 são:
{melhoresFilmesDeTodosOsTempos[0]}
{melhoresFilmesDeTodosOsTempos[1]}
{melhoresFilmesDeTodosOsTempos[2]}
{melhoresFilmesDeTodosOsTempos[3]}");

            var contemFilmeLagoaAzul = melhoresFilmesDeTodosOsTempos.Contains("Lagoa Azul");

            Console.WriteLine("\nO filme lagoa azul existe nessa lista: " + contemFilmeLagoaAzul);

        }

    }
}
