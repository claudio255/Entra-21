using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObejetos
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        //Armazenar o codigo do proximo produto
        private int codigoAtual = 1;

        //encapsulamento + tipoRetorno + NomeMetodo(parâmetro)
        public void Adicionar(int lado1, int lado2, int lado3)
        {
            //Instanciar um trinagulo da classe triangulo
            var triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            triangulo.Codigo = codigoAtual;

            codigoAtual = codigoAtual + 1;

            triangulos.Add(triangulo);
        }

        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            //obtem o triangulo desejado da lista de triangulos
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar); 

            //Verifica se o triangulo existe na lista
            if(trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            //Retorna verdadeiro pq foi possivel editar o triangulo
            return true;
        }

        public bool Apagar(int codigo)
        {
            for(int i = 0; i < triangulos.Count; i++)
            {
                //Resgata de uma lista de tipos primitivos
                var triangulo = triangulos[i];
                if(triangulo.Codigo == codigo)
                {
                    //Para remover um triangulo com o indice do objeto
                    //triangulos.RemoveAt(i);

                    //removendo com o objeto desejado
                    triangulos.Remove(triangulo);

                    //Retornando como verdadeiro pq o objeto da lista foi removido
                    return true;
                }

            }
            //Retorna falso pq o triangulo ou codigo nao foi encontrado na lista, ou seja, nao foi removido o objeto
            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for(int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if(trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }

            }
                return null;
        }

    }
}
