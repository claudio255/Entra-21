namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonPersonagnes = new System.Windows.Forms.Button();
            this.buttonTipoPersonagens = new System.Windows.Forms.Button();
            this.buttonUnidadeFederativa = new System.Windows.Forms.Button();
            this.buttonCidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.Location = new System.Drawing.Point(12, 12);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(123, 167);
            this.buttonEditoras.TabIndex = 0;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = true;
            // 
            // buttonPersonagnes
            // 
            this.buttonPersonagnes.Location = new System.Drawing.Point(141, 12);
            this.buttonPersonagnes.Name = "buttonPersonagnes";
            this.buttonPersonagnes.Size = new System.Drawing.Size(118, 167);
            this.buttonPersonagnes.TabIndex = 1;
            this.buttonPersonagnes.Text = "Personagens";
            this.buttonPersonagnes.UseVisualStyleBackColor = true;
            this.buttonPersonagnes.Click += new System.EventHandler(this.buttonPersonagnes_Click);
            // 
            // buttonTipoPersonagens
            // 
            this.buttonTipoPersonagens.Location = new System.Drawing.Point(265, 12);
            this.buttonTipoPersonagens.Name = "buttonTipoPersonagens";
            this.buttonTipoPersonagens.Size = new System.Drawing.Size(133, 167);
            this.buttonTipoPersonagens.TabIndex = 2;
            this.buttonTipoPersonagens.Text = "Tipo de Personagens";
            this.buttonTipoPersonagens.UseVisualStyleBackColor = true;
            this.buttonTipoPersonagens.Click += new System.EventHandler(this.buttonTipoPersonagens_Click);
            // 
            // buttonUnidadeFederativa
            // 
            this.buttonUnidadeFederativa.Location = new System.Drawing.Point(222, 194);
            this.buttonUnidadeFederativa.Name = "buttonUnidadeFederativa";
            this.buttonUnidadeFederativa.Size = new System.Drawing.Size(133, 157);
            this.buttonUnidadeFederativa.TabIndex = 3;
            this.buttonUnidadeFederativa.Text = "Unidades Federativas";
            this.buttonUnidadeFederativa.UseVisualStyleBackColor = true;
            this.buttonUnidadeFederativa.Click += new System.EventHandler(this.buttonUnidadeFederativa_Click);
            // 
            // buttonCidades
            // 
            this.buttonCidades.Location = new System.Drawing.Point(60, 194);
            this.buttonCidades.Name = "buttonCidades";
            this.buttonCidades.Size = new System.Drawing.Size(140, 157);
            this.buttonCidades.TabIndex = 4;
            this.buttonCidades.Text = "Cidades";
            this.buttonCidades.UseVisualStyleBackColor = true;
            this.buttonCidades.Click += new System.EventHandler(this.buttonCidades_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.Controls.Add(this.buttonCidades);
            this.Controls.Add(this.buttonUnidadeFederativa);
            this.Controls.Add(this.buttonTipoPersonagens);
            this.Controls.Add(this.buttonPersonagnes);
            this.Controls.Add(this.buttonEditoras);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditoras;
        private Button buttonPersonagnes;
        private Button buttonTipoPersonagens;
        private Button buttonUnidadeFederativa;
        private Button buttonCidades;
    }
}