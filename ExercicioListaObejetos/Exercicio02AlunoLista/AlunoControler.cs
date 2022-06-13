namespace ExercicioListaObejetos.Exercicio02AlunoLista
{
    internal class AlunoControler
    {
        private AlunoServico alunoServico = new AlunoServico();
        public void GerenciarMenu()
        {
            Cadastrar();
            Apagar();
            EditarDadosCadastrais();
            EditarNotas();

        }

        private void Cadastrar()
        {
            Console.WriteLine("Digite o nome do aluno(a): ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a materia favorita do aluno(a): ");
            var materiaFavorita = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno(a): ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o codigo de matricula do aluno(a): ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota do aluno(a): ");
            var primeiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno(a): ");
            var segundaNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno(a): ");
            var terceiraNota = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, codigoMatricula, primeiraNota, segundaNota, terceiraNota);
        }

        private void Apagar()
        {
            ApresentarTodosAlunos();

            Console.WriteLine("Digite o nome do aluno(a) que deseja remover: ");
            var nome = Console.ReadLine().Trim().ToLower();

            var alunoRemovido = alunoServico.RemoverAluno(nome);

            if (alunoRemovido == true)
            {
                Console.WriteLine("Aluno(a) removido(a) com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhum aluno com esse nome foi cadastrado!");
            }
        }

        private void EditarDadosCadastrais()
        {
            ApresentarTodosAlunos();

            Console.WriteLine("Digite o codigo de matricula do aluno(a) para alterar seus dados cadastrais: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do aluno(a): ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a materia favorita do aluno(a): ");
            var materiaFavorita = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno(a): ");
            var idade = Convert.ToInt32(Console.ReadLine());

            var dadosAlunoAlterado = alunoServico.EditarDadosCadastrais(codigoMatricula, idade, nome, materiaFavorita);

            if (dadosAlunoAlterado == true)
            {
                Console.WriteLine("Os dados do aluno(a) foi alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("O codigo de matricula nao existe!");
            }
        }

        private void EditarNotas()
        {
            ApresentarTodosAlunos();

            Console.WriteLine("Digite o codigo de matricula do aluno(a): ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota do aluno(a): ");
            var primeiraNota = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno(a): ");
            var segundaNota = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno(a): ");
            var terceiraNota = Convert.ToInt32(Console.ReadLine());

            var notaAlterada = alunoServico.EditarNotasAluno(codigoMatricula, primeiraNota, segundaNota, terceiraNota);

            if(notaAlterada == false)
            {
                Console.WriteLine("O codigo de matricula é inexistente!");
            }
            else
            {
                Console.WriteLine("A nota do aluno(a) foi alterada com sucesso!");
            }
        }

        private void ApresentarNomes() { }

        private void ApresentarMedias() { }

        private void ObterAprovados() { }

        private void ObterReprovados() { }

        private void ObterEmExame() { }

        private void ObterMediaPorCodigoMatricula() { }

        private void ObterStatusPorCodigoMatricula() { }

        private void ObterMediaIdade() { }

        private void ObterAlunoPorCodigoMatricula() { }

        private void ApresentarTodosAlunos() { }


    }
}
