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
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota1Text = new System.Windows.Forms.TextBox();
            this.TextBoxNota2 = new System.Windows.Forms.TextBox();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Nota3 = new System.Windows.Forms.Label();
            this.GerarMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(543, 33);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(39, 15);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "Nota1";
            this.Nota1.Click += new System.EventHandler(this.Nota1_Click);
            // 
            // Nota1Text
            // 
            this.Nota1Text.Location = new System.Drawing.Point(543, 51);
            this.Nota1Text.Name = "Nota1Text";
            this.Nota1Text.Size = new System.Drawing.Size(245, 23);
            this.Nota1Text.TabIndex = 1;
            // 
            // TextBoxNota2
            // 
            this.TextBoxNota2.Location = new System.Drawing.Point(543, 95);
            this.TextBoxNota2.Name = "TextBoxNota2";
            this.TextBoxNota2.Size = new System.Drawing.Size(245, 23);
            this.TextBoxNota2.TabIndex = 2;
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(543, 139);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(245, 23);
            this.textBoxNota3.TabIndex = 3;
            this.textBoxNota3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(543, 77);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(39, 15);
            this.Nota2.TabIndex = 4;
            this.Nota2.Text = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(543, 121);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(39, 15);
            this.Nota3.TabIndex = 5;
            this.Nota3.Text = "Nota3";
            // 
            // GerarMedia
            // 
            this.GerarMedia.Location = new System.Drawing.Point(663, 187);
            this.GerarMedia.Name = "GerarMedia";
            this.GerarMedia.Size = new System.Drawing.Size(125, 49);
            this.GerarMedia.TabIndex = 6;
            this.GerarMedia.Text = "Gerar";
            this.GerarMedia.UseVisualStyleBackColor = true;
            // 
            // MediaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GerarMedia);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.TextBoxNota2);
            this.Controls.Add(this.Nota1Text);
            this.Controls.Add(this.Nota1);
            this.Name = "MediaForms";
            this.Text = "MediaForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nota1;
        private TextBox Nota1Text;
        private TextBox TextBoxNota2;
        private TextBox textBoxNota3;
        private Label Nota2;
        private Label Nota3;
        private Button GerarMedia;
    }
}