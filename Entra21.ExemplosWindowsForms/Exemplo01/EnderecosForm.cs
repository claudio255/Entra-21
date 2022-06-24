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
            for(int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
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

            //Construir o objeto de endereço com as variaveis
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            //Salvar este endereço na lista de endereços e no arquivoJSON
            enderecoServico.Adicionar(endereco);

            //Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEndereco();
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
            for(var i = 0; i < enderecos.Count; i++)
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
            var cep = "89070200";

            //HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            //Executando a requisição para o site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/ {cep}/json/").Result;

            //Verificar se a requisição deu certo
            if(resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text = $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }
    }
}
