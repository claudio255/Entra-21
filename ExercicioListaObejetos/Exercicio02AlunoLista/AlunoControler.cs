namespace ExercicioListaObejetos.Exercicio02AlunoLista
{
    internal class AlunoControler
    {
        private AlunoServico alunoServico = new AlunoServico();


        public void GerenciarMenu()
        {
            int codigo = 0;

            while(codigo != 13)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                Console.Clear();

                if(codigo == 1)
                {
                    ApresentarTodosAlunos();
                }
                else if(codigo == 2)
                {
                    Cadastrar();
                }
                else if(codigo == 3)
                {
                    Apagar();
                }
                else if(codigo == 4)
                {
                    EditarDadosCadastrais();
                }
                else if(codigo == 5)
                {
                    EditarNotas();
                }
                else if(codigo == 6)
                {
                    ApresentarNomes();
                }
                else if(codigo == 7)
                {
                    ObterAprovados();
                }
                else if(codigo == 8)
                {
                    ObterEmExame();
                }
                else if(codigo == 9)
                {
                    ObterReprovados();
                }
                else if(codigo == 10)
                {
                    ObterMediaPorMatricula();
                }
                else if(codigo == 11)
                {
                    ObterStatusPorCodigoMatricula();
                }
                else if(codigo == 12)
                {
                    ObterMediaIdade();
                }
                Console.WriteLine(@"Aperte alguma tecla para continuar......");
                Console.ReadKey();
            }

        }

        private int ApresentarMenu()
        {
            Console.WriteLine(@"----------MENU-------
1 - Apresentar todos os alunos
2 - Cadastrar
3 - Apagar
4 - Editar dados cadastrais do aluno
5 - Editar notas do aluno
6 - Apresentar nomes dos aluno
7 - Apresentar alunos aprovados
8 - Apresentar alunos em exame
9 - Apresentar alunos reprovados
10 - Apresentar media do aluno pelo codigo de sua matricula
11 - Apresentar status do aluno pelo codigo de sua matricula
12 - Apresentar media de idade dos alunos
13 - Sair");
            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;

            while(codigo < 1 || codigo > 13)
            {
                try
                {
                    Console.WriteLine("Digite o codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("O codigo digitado não é valido!");
                }
            }
            return codigo;
        }

        private void Cadastrar()
        {
            Console.WriteLine("Digite o nome do aluno(a): ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a materia favorita do aluno(a): ");
            var materiaFavorita = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno(a): ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota do aluno(a): ");
            var primeiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno(a): ");
            var segundaNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno(a): ");
            var terceiraNota = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, primeiraNota, segundaNota, terceiraNota);
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

            if (notaAlterada == false)
            {
                Console.WriteLine("O codigo de matricula é inexistente!");
            }
            else
            {
                Console.WriteLine("A nota do aluno(a) foi alterada com sucesso!");
            }
        }

        private void ApresentarNomes()
        {
            Console.WriteLine("O nome dos alunos são: ");
            var nomes = alunoServico.ObterNomes();

            for(int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        private void ObterAprovados()
        {
            Console.WriteLine("Os alunos aprovados são: ");
            var aprovados = alunoServico.ObterAprovados(AlunoStatus.Aprovado);
            for (int i = 0; i < aprovados.Count; i++)
            {
                Console.WriteLine(aprovados[i]);
            }
        }

        private void ObterEmExame()
        {
            Console.WriteLine("Os alunos em exame são: ");
            var exame = alunoServico.ObterEmExame();

            for (int i = 0; i < exame.Count; i++)
            {
                Console.WriteLine(exame[i]);
            }
        }

        private void ObterReprovados()
        {
            Console.WriteLine("Os alunos reprovados são: ");
            var reprovados = alunoServico.ObterReprovados(AlunoStatus.Reprovado);

            for (int i = 0; i < reprovados.Count; i++)
            {
                Console.WriteLine(reprovados[i]);
            }
        }

        private void ObterMediaPorMatricula()
        {
            ApresentarTodosAlunos();

            Console.WriteLine("Digite o codigo de matricula do aluno desejado(a): ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(alunoServico.ObterMediaPorCodigoMatricula(codigoMatricula));
        }

        private void ObterStatusPorCodigoMatricula()
        {
            ApresentarTodosAlunos();

            Console.WriteLine("Digite o codigo de matricula do aluno desejado(a): ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(alunoServico.ObterStatusPorCodigoMatricula(codigoMatricula));
        }

        private void ObterMediaIdade()
        {
            Console.WriteLine(alunoServico.ObterMediaIdade());
        }

        private void ApresentarTodosAlunos()
        {
            var alunos = alunoServico.ApresentarTodosAlunos();

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno foi cadastrado ainda!");
                //Return utilizado apenas para parar o metodo
                return;
            }

            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                Console.WriteLine($@"Nome: {alunoAtual.Nome}
Codigo de matricula: {alunoAtual.CodigoMatricula}
Status: {alunoAtual.Status}");
            }
        }
    }
}
