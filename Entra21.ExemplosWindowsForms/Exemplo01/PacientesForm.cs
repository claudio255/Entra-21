using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private List<Paciente> pacientes;

        private int codigoAtual = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;


        public PacientesForm()
        {
            InitializeComponent();
            pacientes = new List<Paciente>();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //Calcular IMC
            var imc = peso / (altura * altura);

            //Para ir acrescentando o codigo em cada paciente
            codigoAtual++;

            //verifica se esta no mode de adiçao
            if (indiceLinhaSelecionada == -1)
            {
                //Adicionar linha no dataGridView de pacientes
                dataGridView1.Rows.Add(new object[] { codigoAtual, nome, altura, peso, imc });
                AdicionarPacientesSalvandoNoArquivo(codigoAtual, nome, peso, altura);
                return;
            }

            //atualizar as informações na tabela
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

            //Para limpar os campos digitado e adicionar um novo paciente
            LimparCampos();

            EditarDados(nome, peso, altura);

        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxAltura.Text = string.Empty;
            textBoxPeso.Text = string.Empty;

            indiceLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente!");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar esse paciente?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuario escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                //Remove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
            else
            {

            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente!");
                return;
            }

            //obter a linha que o usuario selecionou
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //obter a informção da linha selecionada passadndo a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();

            LimparCampos();
        }

        private void AdicionarPacientesSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
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

            pacientes.Add(paciente);

            SalvarEmArquivo();

            LimparCampos();
        }

        private void SalvarEmArquivo()
        {
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
            File.WriteAllText(caminho, pacientesJson);
        }

        private void LerArquivoApresentandoPacientes()
        {
            //Ler arquivo json e armazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            //Cria uma variavel para armazenar o codigo do ultimo produto, para quando cadastrar um novo armazenar com o codigo correto
            var maiorCodigo = int.MinValue;
            
            //Percorre a lista de pacientes
            for(int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //Adicionar o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[] {paciente.Codigo, paciente.Nome, paciente.Altura, paciente.Peso, CalcularImc(paciente.Peso, paciente.Altura)});

                //Rotina para descobrir o paciente com o maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;

            }
            //Validar se conseguiu encontrar algum codigo, caso contrario nao deve atualizar o codigo do novo paciente
            if (maiorCodigo != int.MinValue)
                codigoAtual = maiorCodigo;
        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
            //Substitui isso de baixo:
            //return peso / (altura * altura);
        }
    }
}
