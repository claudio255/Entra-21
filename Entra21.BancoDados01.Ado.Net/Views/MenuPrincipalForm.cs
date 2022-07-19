using Entra21.BancoDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens;
using Entra21.BancoDados01.Ado.Net.Views.UnidadeFederativas;

namespace Entra21.BancoDados01.Ado.Net.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonPersonagnes_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemListagemForm();
            personagemForm.ShowDialog();
        }

        private void buttonTipoPersonagens_Click(object sender, EventArgs e)
        {
            var tipoPersonagem = new TipoPersonagemListagemForm();
            tipoPersonagem.ShowDialog();
        }

        private void buttonUnidadeFederativa_Click(object sender, EventArgs e)
        {
            var unidadeFederativa = new UnidadesFederativasForm();
            unidadeFederativa.ShowDialog();
        }
    }
}
