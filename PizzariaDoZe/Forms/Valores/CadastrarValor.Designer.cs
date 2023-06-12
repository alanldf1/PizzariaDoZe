namespace PizzariaDoZe.Forms.Valores
{
    partial class CadastrarValor
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
            labelValor = new Label();
            labelValorBorda = new Label();
            labelCategoria = new Label();
            listBoxCategoria = new ListBox();
            labelTamanho = new Label();
            listBoxTamanho = new ListBox();
            userControlRegister = new UserControlRegister();
            textBoxValor = new TextBox();
            textBoxValorBorda = new TextBox();
            SuspendLayout();
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.Location = new Point(36, 41);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(50, 25);
            labelValor.TabIndex = 28;
            labelValor.Text = "Valor:";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorBorda.Location = new Point(36, 118);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(162, 25);
            labelValorBorda.TabIndex = 27;
            labelValorBorda.Text = "Valor adicional borda:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoria.Location = new Point(450, 213);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(44, 25);
            labelCategoria.TabIndex = 50;
            labelCategoria.Text = "Tipo:";
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(456, 241);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(309, 94);
            listBoxCategoria.TabIndex = 49;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTamanho.Location = new Point(36, 213);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(82, 25);
            labelTamanho.TabIndex = 48;
            labelTamanho.Text = "Tamanho:";
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(42, 241);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(313, 94);
            listBoxTamanho.TabIndex = 47;
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(142, 388);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(533, 113);
            userControlRegister.TabIndex = 51;
            // 
            // textBoxValor
            // 
            textBoxValor.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValor.Location = new Point(42, 69);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(235, 28);
            textBoxValor.TabIndex = 104;
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorBorda.Location = new Point(42, 158);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.Size = new Size(235, 28);
            textBoxValorBorda.TabIndex = 105;
            // 
            // CadastrarValor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 525);
            Controls.Add(textBoxValorBorda);
            Controls.Add(textBoxValor);
            Controls.Add(userControlRegister);
            Controls.Add(labelCategoria);
            Controls.Add(listBoxCategoria);
            Controls.Add(labelTamanho);
            Controls.Add(listBoxTamanho);
            Controls.Add(labelValor);
            Controls.Add(labelValorBorda);
            Name = "CadastrarValor";
            Text = "CadastrarValor";
            FormClosing += CadastrarValor_FormClosing;
            Load += CadastrarValor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelValor;
        private Label labelValorBorda;
        private Label labelCategoria;
        private ListBox listBoxCategoria;
        private Label labelTamanho;
        private ListBox listBoxTamanho;
        private UserControlRegister userControlRegister;
        private TextBox textBoxValor;
        private TextBox textBoxValorBorda;
    }
}