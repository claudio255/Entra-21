using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        //Construtor: contruir o objeto que esta sendo instanciado com as devidas informções ou rotinas;
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            //Instaciado o objeto de PacienteServico o permitirá listar os pacientes no ComboBox e decorrente disso será possivel o usuario selecionar o mesmo
            pacienteServico = new PacienteServico();

            //Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEndereco();

            //Irá preencher o ComboBox(campo de seleção) com os pacientes
            PreencherComboBoxComOsNomesDosPacientes();

            ObterDadosCep();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            //Obter lista dos pacientes que foram cadastrados, ou seja, armazenadois no JSON
            var pacientes = pacienteServico.ObterTodos();

            //Percorre todos os pacientes adicionado no ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = string.Empty;
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter os dados preenchidos pelo usuario armazenando em variaveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            //Executa o método ValidarDados que retornará um bool, sendo True quando os dados forem válidos
            //False quando os dados forem invalidos
            var dadosValidos = ValidarDados(cep, enderecoCompleto, nomePaciente);

            //Verifica se os dados são invalidos para não dar continuidade no cadastro do endereço
            if (dadosValidos == false)
                return;

            //Verificar senão esta em modo de ediçao, ou seja, modo de cadastro
            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciente);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            //Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEndereco();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            //Obter linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            //Obter codigo que esta na coluna oculta do DataGridView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //Construir o objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            //Atualizar o dadona lista de endereços e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }

        private void CadastrarEndereco(string cep, string enderecoCompleto, string? nomePaciente)
        {
            //Construir o objeto de endereço com as variaveis
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            //Salvar este endereço na lista de endereços e no arquivoJSON
            enderecoServico.Adicionar(endereco);
        }

        private void PreencherDataGridViewComEndereco()
        {
            //Obter todos os endereços da lista de endereços 
            var enderecos = enderecoServico.ObterTodos();

            //Remover todas as linhas do ddataGridView
            dataGridView1.Rows.Clear();

            //Remover a seleção do dataGridView
            dataGridView1.ClearSelection();

            //Percorrer cada um dos endereços adicionado uma nova linha na tela
            for (var i = 0; i < enderecos.Count; i++)
            {
                //obter endereço percorrido
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            //89070200 -> quantidade de caracters 8
            if (cep.Length != 8)
                return;


            //HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            //Executando a requisição para o site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            //Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }

        //Sera executado esse metodo quando o usuario sair do campo de cep
        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {
                MessageBox.Show("CEP invalido!");

                maskedTextBoxCep.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve ter no mínimo 10 caracteres");

                textBoxEnderecoCompleto.Focus();

                return false;
            }

            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente!");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Verificar se algum item do DataGridView está selecionado
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }

            //Questionar se o usuario realmente deseja apagar
            var resposta = MessageBox.Show("Deseja realmente apagar o endereço? ", "Aviso", MessageBoxButtons.YesNo);

            //Validar que o usuario não escolheu Sim, pq não deve continuar executandoo codigo abaixo
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa teu registro ta ali salvo");

                return;
            }

            //Qual item será apagado
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //Obter o codigo da linha selecionada ma primeira coluna, que não esta sendo apresentada paro o usuario,
            //que é referente ao codigo do endereço
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);


            //Apagar o item da lista de itens no serviço
            //Atualizar o arquivo JSON
            //Buscar o endereço na lista de endereços filtrando por codigo
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            //Apagar o endereço encontrado da lista de endereços e atualizar o aquivo JSON
            enderecoServico.Apagar(endereco);

            //Atualizar o DataGridView
            PreencherDataGridViewComEndereco();

            //Remover a seleção do DataGridView
            dataGridView1.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }

            //Obter a linh que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            //Obter o codigo do endereço que o usuario selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            //Obter o endereço escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            //Apresentar os dados do endereço na tela para edição
            maskedTextBoxCep.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }
    }
}
