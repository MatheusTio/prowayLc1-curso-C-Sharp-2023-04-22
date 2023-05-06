namespace WindowsFormExemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.textBoxQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.labelQuantidadeHora = new System.Windows.Forms.Label();
            this.textBoxValorHora = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(126, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do Colaborador";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(339, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Location = new System.Drawing.Point(12, 102);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(138, 15);
            this.labelValorHora.TabIndex = 2;
            this.labelValorHora.Text = "Valor da Hora Trabalhada";
            // 
            // textBoxQuantidadeHoras
            // 
            this.textBoxQuantidadeHoras.Location = new System.Drawing.Point(12, 76);
            this.textBoxQuantidadeHoras.Name = "textBoxQuantidadeHoras";
            this.textBoxQuantidadeHoras.Size = new System.Drawing.Size(182, 23);
            this.textBoxQuantidadeHoras.TabIndex = 3;
            this.textBoxQuantidadeHoras.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelQuantidadeHora
            // 
            this.labelQuantidadeHora.AutoSize = true;
            this.labelQuantidadeHora.Location = new System.Drawing.Point(10, 58);
            this.labelQuantidadeHora.Name = "labelQuantidadeHora";
            this.labelQuantidadeHora.Size = new System.Drawing.Size(184, 15);
            this.labelQuantidadeHora.TabIndex = 4;
            this.labelQuantidadeHora.Text = "Quantidade de Horas Trabalhadas";
            // 
            // textBoxValorHora
            // 
            this.textBoxValorHora.Location = new System.Drawing.Point(12, 120);
            this.textBoxValorHora.Name = "textBoxValorHora";
            this.textBoxValorHora.Size = new System.Drawing.Size(182, 23);
            this.textBoxValorHora.TabIndex = 5;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(10, 159);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(251, 106);
            this.button.TabIndex = 6;
            this.button.Text = "NÃO CLIQUE AQUI";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 640);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxValorHora);
            this.Controls.Add(this.labelQuantidadeHora);
            this.Controls.Add(this.textBoxQuantidadeHoras);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelValorHora;
        private TextBox textBoxQuantidadeHoras;
        private Label labelQuantidadeHora;
        private TextBox textBoxValorHora;
        private Button button;
    }
}