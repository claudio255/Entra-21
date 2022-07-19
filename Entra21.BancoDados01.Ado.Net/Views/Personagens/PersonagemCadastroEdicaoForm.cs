using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public PersonagemCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoPersonagem();

            PreencherComboBoxEditoras();

            _idParaEditar = -1;
        }

        public PersonagemCadastroEdicaoForm(Personagem personagem) : this()
        {
            _idParaEditar = personagem.Id;

            textBoxNome.Text = personagem.Nome;

            //Percorre cada um dos itens do tipo do personagem, para selecionar o que o usuario tinha cadastrado anteriormente
            for (int i = 0; i < comboBoxTipoPersonagem.Items.Count; i++)
            {
                var tipoPersonagemPercorrido = comboBoxTipoPersonagem.Items[i] as TipoPersonagem;

                if (tipoPersonagemPercorrido.Id == personagem.TipoPersonagem.Id)
                {
                    comboBoxTipoPersonagem.SelectedItem = tipoPersonagemPercorrido;
                    //break para apenas o que esta sendo executado o return para o metodo todo
                    break;
                }
            }
            //Percorre cada um dos itens da editora para selecionar o que o usuario tinha cadastrado anteriormente
            for (int i = 0; i < comboBoxEditora.Items.Count; i++)
            {
                var editoraPercorrida = comboBoxEditora.Items[i] as Editora;

                if (editoraPercorrida.Id == personagem.Editora.Id)
                {
                    comboBoxEditora.SelectedItem = editoraPercorrida;
                }
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma editora! SAFADO");

                return;
            }

            if (comboBoxTipoPersonagem.SelectedIndex == -1)
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

            var personagemService = new PersonagemService();
            //Verificar se está no modo de cadastro
            if (_idParaEditar == -1)
            {
                //Persistir o que o usuario escolheu na tabela de personagens
                personagemService.Cadastrar(personagem);

                MessageBox.Show("Personagem cadastrado com sucesso!!");
                Close();
            }
            else
            {
                //Modo de edição
                personagem.Id = _idParaEditar;
                personagemService.Editar(personagem);
                MessageBox.Show("Personagem alterado com sucesso!");
                Close();
            }
        }

        private void PreencherComboBoxTipoPersonagem()
        {
            //Buscar todos os tipo de personagens do banco de dados para permitir escolher
            var tipoPersonagemService = new TipoPersonagemService();
            var tipoPersonagens = tipoPersonagemService.ObterTodos();

            for (int i = 0; i < tipoPersonagens.Count; i++)
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

            for (int i = 0; i < editoras.Count; i++)
            {
                var editora = editoras[i];
                comboBoxEditora.Items.Add(editora);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
