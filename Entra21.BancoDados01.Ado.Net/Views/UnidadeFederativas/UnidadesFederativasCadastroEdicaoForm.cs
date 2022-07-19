using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadeFederativas
{
    public partial class UnidadesFederativasCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public UnidadesFederativasCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public UnidadesFederativasCadastroEdicaoForm(UnidadesFederativas unidadeFederativa) : this()
        {
            _idParaEditar = unidadeFederativa.Id;

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

            if (_idParaEditar == -1)
            {
                unidadeFederativaService.Cadastrar(unidadeFederativa);

                MessageBox.Show("Unidade Federativa cadastrada com sucesso!");
                Close();
            }
            else
            {
                unidadeFederativa.Id = _idParaEditar;
                unidadeFederativaService.Editar(unidadeFederativa);

                MessageBox.Show("Unidade federativa alterada com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
