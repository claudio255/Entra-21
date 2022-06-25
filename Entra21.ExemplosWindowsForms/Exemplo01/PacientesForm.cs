namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private PacienteServico pacienteServico;

        public PacientesForm()
        {
            InitializeComponent();

            //Instanciar um objeto do PacienteServico, que é responsavel por gerenciar os dados dos pacientes
            pacienteServico = new PacienteServico();

            //Ler do arquivo Json os pacientes cadastrados anteriormente
            ListarPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //verifica se esta no mode de adiçao
            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarPaciente(nome, peso, altura);

                return;
            }

            EditarDados(nome, peso, altura);
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxAltura.Clear();
            textBoxPeso.Clear();

            dataGridView1.ClearSelection();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Obter a quantidade de linhas que o usuario selecionou no DataGridView
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente!");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar esse paciente?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuario escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                //Obtem o codigo do paciente escolhido para apagar
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                //Apaga o paciente da lista de pacientes atualizando o arquivo JSON
                pacienteServico.Apagar(codigoSelecionado);

                ListarPacientes();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente!");
                return;
            }

            //obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //obter a informção da linha selecionada passadndo a coluna desejada
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            //Instanciar o paciente com os dados preenchidos na tela, para alterar o existente
            var paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Peso = peso;
            paciente.Altura = altura;

            //Obter o codigo do registro escolhido para alterar
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            paciente.Codigo = codigo;

            //Alterar o paciente na lista de pacientes e atualizando o arquivo JSON
            pacienteServico.Editar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void AdicionarPaciente(string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = pacienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };

            //ISSO SUBSTITUI O DE CIMA:
            //var paciente = new Paciente();
            //paciente.Codigo = codigo;
            //paciente.Nome = nome;
            //paciente.Altura = altura;
            //paciente.Peso = peso;

            //Adicionar na lista e atualizar o arquivo JSON
            pacienteServico.Cadastrar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void ListarPacientes()
        {        
            //Obter a lista dos pacientes e listar para o usuario
            var pacientes = pacienteServico.ObterTodos();

            //Remover todos os itens do DataGridView, pois será adicionado novamente
            dataGridView1.Rows.Clear();

            //Percorre a lista de pacientes
            for(int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //Adicionar o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo,
                    paciente.Nome,
                    paciente.Altura,
                    paciente.Peso,
                    paciente.ObterImc()
                });
            }

            dataGridView1.ClearSelection();
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }
    }
}
