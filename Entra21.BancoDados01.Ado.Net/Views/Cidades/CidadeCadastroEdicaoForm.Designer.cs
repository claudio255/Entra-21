namespace Entra21.BancoDados01.Ado.Net.Views.Cidades
{
    partial class CidadeCadastroEdicaoForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeHabitantes = new System.Windows.Forms.TextBox();
            this.textBoxPib = new System.Windows.Forms.TextBox();
            this.comboBoxUnidadesFederativas = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataHoraFundacao = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(154, 243);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 243);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data/Hora de Fundação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de Habitantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "PIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unidades Federativas";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 71);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(217, 23);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxQuantidadeHabitantes
            // 
            this.textBoxQuantidadeHabitantes.Location = new System.Drawing.Point(12, 115);
            this.textBoxQuantidadeHabitantes.Name = "textBoxQuantidadeHabitantes";
            this.textBoxQuantidadeHabitantes.Size = new System.Drawing.Size(217, 23);
            this.textBoxQuantidadeHabitantes.TabIndex = 9;
            this.textBoxQuantidadeHabitantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantidadeHabitantes_KeyPress);
            // 
            // textBoxPib
            // 
            this.textBoxPib.Location = new System.Drawing.Point(12, 204);
            this.textBoxPib.Name = "textBoxPib";
            this.textBoxPib.Size = new System.Drawing.Size(217, 23);
            this.textBoxPib.TabIndex = 10;
            this.textBoxPib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPib_KeyPress);
            // 
            // comboBoxUnidadesFederativas
            // 
            this.comboBoxUnidadesFederativas.DisplayMember = "Nome";
            this.comboBoxUnidadesFederativas.FormattingEnabled = true;
            this.comboBoxUnidadesFederativas.Location = new System.Drawing.Point(12, 27);
            this.comboBoxUnidadesFederativas.Name = "comboBoxUnidadesFederativas";
            this.comboBoxUnidadesFederativas.Size = new System.Drawing.Size(217, 23);
            this.comboBoxUnidadesFederativas.TabIndex = 11;
            // 
            // dateTimePickerDataHoraFundacao
            // 
            this.dateTimePickerDataHoraFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataHoraFundacao.Location = new System.Drawing.Point(12, 160);
            this.dateTimePickerDataHoraFundacao.Name = "dateTimePickerDataHoraFundacao";
            this.dateTimePickerDataHoraFundacao.Size = new System.Drawing.Size(217, 23);
            this.dateTimePickerDataHoraFundacao.TabIndex = 12;
            // 
            // CidadeCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 283);
            this.Controls.Add(this.dateTimePickerDataHoraFundacao);
            this.Controls.Add(this.comboBoxUnidadesFederativas);
            this.Controls.Add(this.textBoxPib);
            this.Controls.Add(this.textBoxQuantidadeHabitantes);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "CidadeCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidadeHabitantes;
        private TextBox textBoxPib;
        private ComboBox comboBoxUnidadesFederativas;
        private DateTimePicker dateTimePickerDataHoraFundacao;
    }
}