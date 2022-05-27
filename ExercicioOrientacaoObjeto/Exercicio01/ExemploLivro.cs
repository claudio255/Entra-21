using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            livro.Autor = "Cláudio Henrique Raimundo";
            livro.Titulo = "A volta dos que não foram";
            livro.CodigoIsbn = "978-3-16-148410-0";
            livro.IdiomaOriginal = "Português";
            livro.QuantidadePaginas = 200;
            livro.QuantidadePaginasLidas = 14;
            livro.QuantidadeReleituras = 0;
            livro.DataLancamento = new DateTime(2002, 07, 18);

            Console.WriteLine($@"{livro.ApresentarTituloAutor()}
A quantidade de paginas restantes é: {livro.ApresentarQuantidadePaginasLer()}
A quantidade paginas lidas ao total é de: {livro.ApresentarQuantidadePaginasLidasNoTotal()}");

        }
    }
}
