using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        public string Titulo, Autor, CodigoIsbn, IdiomaOriginal;
        public int QuantidadePaginas, QuantidadePaginasLidas, QuantidadeReleituras;
        public DateTime DataLancamento;
        public string ApresentarTituloAutor()
        {
            Console.WriteLine("O titulo do livro é: " + Titulo);
            Console.WriteLine("O autor do livro é: " + Autor);

            return Titulo + Autor;
        }

        //ApresentarQuantidadePaginasParaLer
        public int ApresentarQuantidadePaginasLer()
        {
            var paginasRestantes = QuantidadePaginas - QuantidadePaginasLidas;

            return paginasRestantes;
        }

        //ApresentarQuantidadePaginasLidasNoTotal
        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            var quantidadePaginasLidasAoTotal = (QuantidadePaginasLidas * QuantidadeReleituras);

            if (QuantidadeReleituras <= 0)
            {
                quantidadePaginasLidasAoTotal = QuantidadePaginasLidas;
            }

            return quantidadePaginasLidasAoTotal;
        }

    }
}
