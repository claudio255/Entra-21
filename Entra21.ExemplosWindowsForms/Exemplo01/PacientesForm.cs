namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private int codigoAtual = 1;
        private int indeceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
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
            if (indeceLinhaSelecionada == -1)
            {
                //Adicionar linha no dataGridView de pacientes
                dataGridView1.Rows.Add(new object[] { codigoAtual, nome, altura, peso, imc });
                return;
            }

            //atualizar as informações na tabela
            dataGridView1.Rows[indeceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indeceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indeceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indeceLinhaSelecionada].Cells[4].Value = imc.ToString();

            //Para limpar os campos digitado e adicionar um novo paciente
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxAltura.Text = string.Empty;
            textBoxPeso.Text = string.Empty;

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
            indeceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indeceLinhaSelecionada == -1)
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
    }
}
