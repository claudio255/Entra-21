namespace Entra21.ExemplosWindowsForms.exemplo02
{
    public partial class MediaForms : Form
    {
        private int codigoAtual = 0;
        private int indiceLinhaSelecionada = -1;
        public MediaForms()
        {
            InitializeComponent();
        }

        private void Nota1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GerarMedia_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var nota1 = Convert.ToDouble(textBoxNota1.Text.Trim());
            var nota2 = Convert.ToDouble(textBoxNota2.Text.Trim());
            var nota3 = Convert.ToDouble(textBoxNota3.Text.Trim());

            var gerar = (nota1 + nota2 + nota3) / 3;

            codigoAtual++;

            if(indiceLinhaSelecionada == -1)
            {
                dataGridView1.Rows.Add(new object[] { codigoAtual,nome, nota1, nota2, nota3, gerar});
                return;
            }

            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = nota1.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = nota2.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = nota3.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[5].Value = gerar.ToString();
           
            //MessageBox.Show("A media atual do aluno é: " + gerar);

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNota1.Text = string.Empty;
            textBoxNota2.Text = string.Empty;
            textBoxNota3.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MediaForms_Load(object sender, EventArgs e)
        {

        }
    }
}
