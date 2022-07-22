using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public CidadeCadastroEdicaoForm()
        {
            InitializeComponent();

            dateTimePickerDataHoraFundacao.MaxDate = DateTime.Today;

            PreencherComboBoxComUnidadesFederativas();

            _idParaEditar = -1;
        }

        public CidadeCadastroEdicaoForm(Cidade cidade) : this()
        {
            _idParaEditar = cidade.Id;

            textBoxNome.Text = cidade.Nome;
            textBoxQuantidadeHabitantes.Text = cidade.QuantidadeHabitantes.ToString();
            dateTimePickerDataHoraFundacao.Text = cidade.DataHoraFundacao.ToString();
            textBoxPib.Text = cidade.Pib.ToString();

            for (int i = 0; i < comboBoxUnidadesFederativas.Items.Count; i++)
            {
                var unidadeFederativaPercorrida = comboBoxUnidadesFederativas.Items[i] as UnidadeFederativa;

                if (unidadeFederativaPercorrida.Id == cidade.UnidadesFederativas.Id)
                {
                    comboBoxUnidadesFederativas.SelectedItem = unidadeFederativaPercorrida;
                    break;
                }
            }
        }

        private void PreencherComboBoxComUnidadesFederativas()
        {
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidadesFederativas = unidadeFederativaService.ObterTodos();

            for (int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];
                comboBoxUnidadesFederativas.Items.Add(unidadeFederativa);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidadeHabitantes = textBoxQuantidadeHabitantes.Text.Trim();
            var dataHoraFundacao = dateTimePickerDataHoraFundacao.Text;
            var pib = textBoxPib.Text;
            var unidadeFederativa = comboBoxUnidadesFederativas.SelectedItem as UnidadeFederativa;
            var cidade = new Cidade();

            ValidarDados();

            cidade.Nome = nome;
            cidade.QuantidadeHabitantes = Convert.ToInt32(quantidadeHabitantes);
            cidade.DataHoraFundacao = Convert.ToDateTime(dataHoraFundacao);
            cidade.Pib = Convert.ToDouble(pib);
            cidade.UnidadesFederativas = unidadeFederativa;

            var cidadeService = new CidadeService();

            if (_idParaEditar == -1)
            {
                cidadeService.Cadastrar(cidade);

                MessageBox.Show("Cidade cadastrada com sucesso!");
                Close();
            }
            else
            {
                cidade.Id = _idParaEditar;
                cidadeService.Editar(cidade);
                MessageBox.Show("Cidade alterada com sucesso!");
                Close();
            }
        }

        private bool ValidarDados()
        {
            if (comboBoxUnidadesFederativas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federativa!");
                return false;
            }
            if ((textBoxNome.Text.Length < 5) || (textBoxNome.Text.Length > 100))
            {
                MessageBox.Show("O nome digitado deve conter no minímo 5 caracteres e no máximo 100");
                return false;
            }
            if (textBoxQuantidadeHabitantes.Text == string.Empty)
            {
                MessageBox.Show("A quantidade de habitantes deve ser preenchida!");
                return false;
            }
            var validarQuantidadeHabitantes = Convert.ToInt32(textBoxQuantidadeHabitantes.Text);
            if (validarQuantidadeHabitantes < 1000 || validarQuantidadeHabitantes > 20000000)
            {
                MessageBox.Show(@"A quantidade de habitantes não pode ser inferior que mil habitantes ou superior que 20 milhões!!");
                return false;
            }

            if (dateTimePickerDataHoraFundacao.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("A data de fundação não pode ser superior a data de hoje!");
                return false;
            }
            if (textBoxPib.Text == string.Empty)
            {
                MessageBox.Show("O PIB deve ser preenchido!");
                return false;
            }
            var validarPib = Convert.ToDouble(textBoxPib.Text);
            if (validarPib < 100000.00 || validarPib > 5000000000.00 || validarPib == null)
            {
                MessageBox.Show("O PIB não pode ser inferior que 100 mil ou superior à 5 trilhões!");
                return false;
            }

            return true;
        }

        private void textBoxQuantidadeHabitantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar > (char)8)
            {
                MessageBox.Show("Insira apenas numeros!");
                e.Handled = true;
            }
        }

        private void textBoxPib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar > (char)8)
            {
                MessageBox.Show("Insira apenas numeros!");
                e.Handled = true;
            }
        }
    }
}

