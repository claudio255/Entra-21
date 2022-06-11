using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObejetos
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 6)
            {
                codigo = ApresentarSolicitarMenu();

                if (codigo == 1)
                {
                    ApresentarTodosTriangulos();
                }
                else if (codigo == 2)
                {
                    CadastrarTriangulo();
                }
                else if (codigo == 3)
                {
                    Apagar();
                }
                else if (codigo == 4)
                {
                    Editar();
                }
                else if (codigo == 5)
                {
                    ApresentarTriangulosEspecificos();
                }

                Console.WriteLine("Digite qualquer tecla para continuar....");
                Console.ReadKey();
                Console.Clear();
            }

        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"----------Menu----------
1 - Listar Todos
2 - Cadastrar
3 - Apagar
4 - Editar
5 - Apresentar Triangulo Específico
6 - Sair");
            var codigo = SolicitarCodigo();

            return codigo;
        }

        private void ApresentarTodosTriangulos()
        {
            var triangulo = trianguloServico.ObterTodos();

            if (triangulo.Count == 0)
            {
                Console.WriteLine("Nenhum triangulo cadastrado!");

                return;
            }

            for (var i = 0; i < triangulo.Count; i++)
            {
                var trianguloAtual = triangulo[i];

                Console.WriteLine($@"Codigo: {trianguloAtual.Codigo}
Lado1: {trianguloAtual.Lado1}
Lado2: {trianguloAtual.Lado2}
Lado3: {trianguloAtual.Lado3}");

            }
        }

        private void CadastrarTriangulo()
        {
            Console.WriteLine("Digite o tamanho do lado1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do lado2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do lado3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);

        }

        private void Apagar()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Digite o codigo do triangulo que deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);

            if(registroApagado == true)
            {
                Console.WriteLine("Registro do triangulo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhum triangulo encontrdo com esse codigo!");
            }
        }

        private void Editar()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Digite o codigo do triangulo que será alterado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var alterou = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if(alterou == false)
            {
                Console.WriteLine("O codigo digitado não existe!");
            }
            else
            {
                Console.WriteLine("Triangulo alterado com sucesso!");
            }
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.WriteLine("Digite o codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um codigo valido!");
                }
            }

            return codigo;
        }

        private void ApresentarTriangulosEspecificos()
        {
            ApresentarTodosTriangulos();

            Console.WriteLine("Digite o codigo do triangulo que deseja: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (codigo == null)
            {
                Console.WriteLine("O triangulo desejado não existe!");

                return;
            }

            Console.Clear();
            Console.WriteLine($@"Codigo: {triangulo.Codigo}
Lado1: {triangulo.Lado1}
Lado2: {triangulo.Lado2}
Lado3: {triangulo.Lado3}");
        }

    }
}
