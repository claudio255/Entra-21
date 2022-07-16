using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemCadastroEdicaoForm : Form
    {
        public PersonagemCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPersonagem();

            PreencherComboBoxEditoras();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if(comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma editora! SAFADO");

                return;
            }

            if(comboBoxTipoPersonagem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de personagem! PANACA");
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var tipoPersonagem = comboBoxTipoPersonagem.SelectedItem as TipoPersonagem;
            var editora = comboBoxEditora.SelectedItem as Editora;

            var personagem = new Personagem();
            personagem.Nome = nome;
            personagem.TipoPersonagem = tipoPersonagem;
            personagem.Editora = editora;

            //Persistir o que o usuario escolheu na tabela de personagens
            var personagemService = new PersonagemService();
            personagemService.Cadastrar(personagem);

            MessageBox.Show("Personagem cadastrado com sucesso!!");
            Close();
        }

        private void PreencherComboBoxTipoPersonagem()
        {
            //Buscar todos os tipo de personagens do banco de dados para permitir escolher
            var tipoPersonagemService = new TipoPersonagemService();
            var tipoPersonagens = tipoPersonagemService.ObterTodos();

            for(int i = 0; i < tipoPersonagens.Count; i++)
            {
                var tipoPersonagem = tipoPersonagens[i];
                comboBoxTipoPersonagem.Items.Add(tipoPersonagem);
            }
        }

        private void PreencherComboBoxEditoras()
        {
            //Buscar todas os tipos de editoras do banco de dados para permitir escolher
            var editoraService = new EditoraService();
            var editoras = editoraService.ObterTodos();

            for(int i = 0; i < editoras.Count; i++)
            {
                var tipoEditora = editoras[i];
                comboBoxEditora.Items.Add(tipoEditora);
            }
        }
    }
}
