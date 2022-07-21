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
            if ((textBoxNome.Text.Length < 3) || (textBoxNome.Text.Length > 150))
            {
                MessageBox.Show("O nome da Unidade Federativa deve conter no minímo 5 caracteres e no máximo 150");
                return;
            }
            if(textBoxSigla.Text.Length != 2)
            {
                MessageBox.Show("A sigla da Unidade Federativa só pode conter duas letras!");
                return;
            }
            var nome = textBoxNome.Text.Trim();
            var sigla = textBoxSigla.Text.Trim().ToUpper();

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
