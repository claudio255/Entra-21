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
            maskedTextBoxDataHoraFundacao.Text = cidade.DataHoraFundacao.ToString();
            textBoxPib.Text = cidade.Pib.ToString(); 

            for(int i = 0; i < comboBoxUnidadesFederativas.Items.Count; i++)
            {
                var unidadeFederativaPercorrida = comboBoxUnidadesFederativas.Items[i] as UnidadesFederativas;

                if(unidadeFederativaPercorrida.Id == cidade.UnidadesFederativas.Id)
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

            for(int i = 0; i < unidadesFederativas.Count; i++)
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
            if(comboBoxUnidadesFederativas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Unidade Federativa!");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var quantidadeHabitantes = textBoxQuantidadeHabitantes.Text.Trim();
            var dataHoraFundacao = maskedTextBoxDataHoraFundacao.Text;
            var pib = textBoxPib.Text.Trim();
            var unidadeFederativa = comboBoxUnidadesFederativas.SelectedItem as UnidadesFederativas;
            var cidade = new Cidade();
            cidade.Nome = nome;
            cidade.QuantidadeHabitantes = Convert.ToInt32(quantidadeHabitantes.Trim());
            cidade.DataHoraFundacao = Convert.ToDateTime(dataHoraFundacao);
            cidade.Pib = Convert.ToDouble(pib.Trim());
            cidade.UnidadesFederativas = unidadeFederativa;

            var cidadeService = new CidadeService();

            if(_idParaEditar == -1)
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
