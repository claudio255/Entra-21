namespace Entra21.ExemplosWindowsForms.Exemplo01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonEndereco = new System.Windows.Forms.Button();
            this.buttonPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Image = ((System.Drawing.Image)(resources.GetObject("buttonEndereco.Image")));
            this.buttonEndereco.Location = new System.Drawing.Point(12, 12);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(238, 272);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereços";
            this.buttonEndereco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.buttonEndereco_Click);
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaciente.Image")));
            this.buttonPaciente.Location = new System.Drawing.Point(256, 12);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(258, 272);
            this.buttonPaciente.TabIndex = 1;
            this.buttonPaciente.Text = "Pacientes";
            this.buttonPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPaciente.UseVisualStyleBackColor = true;
            this.buttonPaciente.Click += new System.EventHandler(this.buttonPaciente_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 286);
            this.Controls.Add(this.buttonPaciente);
            this.Controls.Add(this.buttonEndereco);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEndereco;
        private Button buttonPaciente;
    }
}