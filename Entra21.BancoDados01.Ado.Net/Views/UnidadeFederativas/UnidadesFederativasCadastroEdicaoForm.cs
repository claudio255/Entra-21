using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadeFederativas
{
    public partial class UnidadesFederativasCadastroEdicaoForm : Form
    {
        private readonly int idEdicao = -1;

        public UnidadesFederativasCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public UnidadesFederativasCadastroEdicaoForm(UnidadesFederativas unidadeFederativa) : this()
        {
            idEdicao = unidadeFederativa.Id;

            textBoxNome.Text = unidadeFederativa.Nome;
            textBoxSigla.Text = unidadeFederativa.Sigla;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var sigla = textBoxSigla.Text.Trim();

            var unidadeFederativa = new UnidadesFederativas();
            unidadeFederativa.Nome = nome;
            unidadeFederativa.Sigla = sigla;

            var unidadeFederativaService = new UnidadesFederativasService();

            if(idEdicao == -1)
            {
                MessageBox.Show("Unidade Federativa cadastrada com sucesso!");

                Close();

                return;
            }

            unidadeFederativa.Id = idEdicao;
            unidadeFederativaService.Editar(unidadeFederativa);

            MessageBox.Show("Unidade federativa alterada com sucesso");

            Close();
        }
    }
}
