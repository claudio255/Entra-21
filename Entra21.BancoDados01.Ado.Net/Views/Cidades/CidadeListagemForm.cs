using Entra21.BancoDados01.Ado.Net.Services;

namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    public partial class CidadeListagemForm : Form
    {
        private readonly CidadeService _cidadeService;

        public CidadeListagemForm()
        {
            InitializeComponent();

            _cidadeService = new CidadeService();

            PreencherDataGridViewComCidades();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cidadeForm = new CidadeCadastroEdicaoForm();
            cidadeForm.ShowDialog();

            PreencherDataGridViewComCidades();
        }

        private void PreencherDataGridViewComCidades()
        {
            var cidades = _cidadeService.ObterTodas();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < cidades.Count; i++)
            {
                var cidade = cidades[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cidade.Id,
                    cidade.Nome,
                    cidade.UnidadesFederativas.Nome,
                    cidade.QuantidadeHabitantes,
                    cidade.DataHoraFundacao,
                    cidade.Pib,
                    cidade.UnidadesFederativas.Sigla
                }) ;
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _cidadeService.Apagar(id);

            PreencherDataGridViewComCidades();

            MessageBox.Show("Registro removido com sucesso!");
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

            var cidade = _cidadeService.ObterPorId(id);

            var cidadeCadastroEdicaoForm = new CidadeCadastroEdicaoForm(cidade);
            cidadeCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComCidades();
        }
    }
}
