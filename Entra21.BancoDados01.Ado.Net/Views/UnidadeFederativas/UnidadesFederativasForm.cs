using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadeFederativas
{
    public partial class UnidadesFederativasForm : Form
    {
        private readonly UnidadesFederativasService _unidadesFederativasService;

        public UnidadesFederativasForm()
        {
            InitializeComponent();

            _unidadesFederativasService = new UnidadesFederativasService();

            PreencherDataGridViewComUnidadesFederativas();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }

            var respostaUsuario = MessageBox.Show("Deseja realmente apagar esse registro?", "Aviso", MessageBoxButtons.YesNo);
            if(respostaUsuario != DialogResult.Yes)
            {
                MessageBox.Show("O registro não foi apagado! Relaxa pow!!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _unidadesFederativasService.Apagar(id);

            PreencherDataGridViewComUnidadesFederativas();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void PreencherDataGridViewComUnidadesFederativas()
        {
            var unidadesFederativas = _unidadesFederativasService.ObterTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < unidadesFederativas.Count; i++)
            {
                var unidadeFederativa = unidadesFederativas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    unidadeFederativa.Id,
                    unidadeFederativa.Nome,
                    unidadeFederativa.Sigla
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var unidadesFederativasCadastroEdicaoForm = new UnidadesFederativasCadastroEdicaoForm();
            unidadesFederativasCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }
            

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var unidadeFederativa = _unidadesFederativasService.ObterPorId(id);
            var unidadeFederativaCadastroEdicaoForm = new UnidadesFederativasCadastroEdicaoForm(unidadeFederativa);
            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComUnidadesFederativas();
        }
    }
}
