using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.UnidadeFederativas
{
    public partial class UnidadesFederativasForm : Form
    {
        private UnidadesFederativasService unidadesFederativasService;

        public UnidadesFederativasForm()
        {
            InitializeComponent();

            unidadesFederativasService = new UnidadesFederativasService();
        }

        private void UnidadesFederativasForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroNoDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            unidadesFederativasService.Apagar(id);

            AtualizarRegistroNoDataGridView();

            MessageBox.Show("Registro apagado com sucesso!");
        }

        private void AtualizarRegistroNoDataGridView()
        {
            var unidadesFederativas = unidadesFederativasService.ObterTodos();

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

            AtualizarRegistroNoDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum tipo de personagem!");
                return;
            }

            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var unidadeFederativa = unidadesFederativasService.ObterPorId(id);
            var unidadeFederativaCadastroEdicaoForm = new UnidadesFederativasCadastroEdicaoForm(unidadeFederativa);

            unidadeFederativaCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroNoDataGridView();
        }
    }
}
