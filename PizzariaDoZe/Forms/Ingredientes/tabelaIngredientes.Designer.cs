namespace PizzariaDoZe.Forms.Ingredientes
{
    partial class tabelaIngredientes
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
            label1 = new Label();
            dataGridViewIngredientes = new DataGridView();
            textBoxPesquisa = new TextBox();
            labelPesquisa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-6, -28);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // dataGridViewIngredientes
            // 
            dataGridViewIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredientes.Location = new Point(25, 145);
            dataGridViewIngredientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewIngredientes.Name = "dataGridViewIngredientes";
            dataGridViewIngredientes.RowHeadersWidth = 51;
            dataGridViewIngredientes.RowTemplate.Height = 29;
            dataGridViewIngredientes.Size = new Size(719, 224);
            dataGridViewIngredientes.TabIndex = 20;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(25, 60);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 0;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(20, 27);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 19;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // tabelaIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 443);
            Controls.Add(dataGridViewIngredientes);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tabelaIngredientes";
            Text = "tabelaIngredientes";
            Load += tabelaIngredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewIngredientes;
        private TextBox textBoxPesquisa;
        private Label labelPesquisa;
    }
}