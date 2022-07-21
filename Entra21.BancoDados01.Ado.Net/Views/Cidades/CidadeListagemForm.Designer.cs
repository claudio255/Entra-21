namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeListagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnidadeFederativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeHabitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataHoraFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(704, 48);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(623, 48);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(542, 48);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnUnidadeFederativa,
            this.ColumnSigla,
            this.ColumnQuantidadeHabitantes,
            this.ColumnDataHoraFundacao,
            this.ColumnPib});
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 140;
            // 
            // ColumnUnidadeFederativa
            // 
            this.ColumnUnidadeFederativa.HeaderText = "Unidade Federativa";
            this.ColumnUnidadeFederativa.Name = "ColumnUnidadeFederativa";
            this.ColumnUnidadeFederativa.ReadOnly = true;
            this.ColumnUnidadeFederativa.Width = 130;
            // 
            // ColumnSigla
            // 
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            this.ColumnSigla.ReadOnly = true;
            this.ColumnSigla.Width = 50;
            // 
            // ColumnQuantidadeHabitantes
            // 
            this.ColumnQuantidadeHabitantes.HeaderText = "Quantidade de Habitantes";
            this.ColumnQuantidadeHabitantes.Name = "ColumnQuantidadeHabitantes";
            this.ColumnQuantidadeHabitantes.ReadOnly = true;
            // 
            // ColumnDataHoraFundacao
            // 
            this.ColumnDataHoraFundacao.HeaderText = "Data/Hora Fundação";
            this.ColumnDataHoraFundacao.Name = "ColumnDataHoraFundacao";
            this.ColumnDataHoraFundacao.ReadOnly = true;
            this.ColumnDataHoraFundacao.Width = 125;
            // 
            // ColumnPib
            // 
            this.ColumnPib.HeaderText = "PIB";
            this.ColumnPib.Name = "ColumnPib";
            this.ColumnPib.ReadOnly = true;
            this.ColumnPib.Width = 130;
            // 
            // CidadeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "CidadeListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnUnidadeFederativa;
        private DataGridViewTextBoxColumn ColumnSigla;
        private DataGridViewTextBoxColumn ColumnQuantidadeHabitantes;
        private DataGridViewTextBoxColumn ColumnDataHoraFundacao;
        private DataGridViewTextBoxColumn ColumnPib;
    }
}