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
                var unidadeFederativaPercorrida = comboBoxUnidadesFederativas.Items[i] as UnidadesFederativas;

                if (unidadeFederativaPercorrida.Id == cidade.UnidadesFederativas.Id)
                {
                    comboBoxUnidadesFederativas.SelectedItem = unidadeFederativaPercorrida;
                    break;
                }
            }
        }

        private void PreencherComboBoxComUnidadesFederativas()
        {
            var unidadeFederativaService = new UnidadesFederativasService();
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
            var pib = Convert.ToDouble(textBoxPib.Text.Trim());
            var unidadeFederativa = comboBoxUnidadesFederativas.SelectedItem as UnidadesFederativas;

            if (comboBoxUnidadesFederativas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federativa!");
                return;
            }
            if ((textBoxNome.Text.Length < 5) || (textBoxNome.Text.Length > 150))
            {
                MessageBox.Show("O nome digitado deve conter no minímo 5 caracteres e no máximo 150");
                return;
            }
            if((textBoxQuantidadeHabitantes.Text.Length <= 3) || (textBoxQuantidadeHabitantes.Text.Length > 50000000))
            {
                MessageBox.Show("A quantidade de habitantes deve conter um numero valido!");
                return;
            }
            if((textBoxPib.Text.Length <= 5) || (textBoxPib.Text.Length > 2000000000))
            {
                MessageBox.Show("O PIB não pode ser inferior que 100 mil ou superior à 2 trilhões!");
                return;
            }

            var cidade = new Cidade();
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
    }
}

