namespace Entra21.ExemplosWindowsForms.exemplo02
{
    partial class MediaForms
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
            this.nota1 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.Label();
            this.gerarMedia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.Location = new System.Drawing.Point(543, 88);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(39, 15);
            this.nota1.TabIndex = 0;
            this.nota1.Text = "Nota1";
            this.nota1.Click += new System.EventHandler(this.Nota1_Click);
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(543, 106);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(245, 23);
            this.textBoxNota1.TabIndex = 1;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(543, 150);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(245, 23);
            this.textBoxNota2.TabIndex = 2;
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(543, 194);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(245, 23);
            this.textBoxNota3.TabIndex = 3;
            this.textBoxNota3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Location = new System.Drawing.Point(543, 132);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(39, 15);
            this.nota2.TabIndex = 4;
            this.nota2.Text = "Nota2";
            // 
            // nota3
            // 
            this.nota3.AutoSize = true;
            this.nota3.Location = new System.Drawing.Point(543, 176);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(39, 15);
            this.nota3.TabIndex = 5;
            this.nota3.Text = "Nota3";
            // 
            // gerarMedia
            // 
            this.gerarMedia.Location = new System.Drawing.Point(663, 223);
            this.gerarMedia.Name = "gerarMedia";
            this.gerarMedia.Size = new System.Drawing.Size(125, 49);
            this.gerarMedia.TabIndex = 6;
            this.gerarMedia.Text = "Gerar";
            this.gerarMedia.UseVisualStyleBackColor = true;
            this.gerarMedia.Click += new System.EventHandler(this.GerarMedia_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(509, 387);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CodigoAtual";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nota1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nota2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nota3";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Media";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(543, 44);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(543, 62);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(245, 23);
            this.textBoxNome.TabIndex = 9;
            // 
            // MediaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gerarMedia);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.nota1);
            this.Name = "MediaForms";
            this.Text = "MediaForms";
            this.Load += new System.EventHandler(this.MediaForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nota1;
        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private TextBox textBoxNota3;
        private Label nota2;
        private Label nota3;
        private Button gerarMedia;
        private DataGridView dataGridView1;
        private Label labelNome;
        private TextBox textBoxNome;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}