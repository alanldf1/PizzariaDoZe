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
            labelPesquisa = new Label();
            label1 = new Label();
            textBoxPesquisa = new TextBox();
            dataGridViewIngredientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(23, 36);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(112, 34);
            labelPesquisa.TabIndex = 19;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, -37);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 18;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(29, 80);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(418, 37);
            textBoxPesquisa.TabIndex = 0;
            // 
            // dataGridViewIngredientes
            // 
            dataGridViewIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredientes.Location = new Point(29, 193);
            dataGridViewIngredientes.Name = "dataGridViewIngredientes";
            dataGridViewIngredientes.RowHeadersWidth = 51;
            dataGridViewIngredientes.RowTemplate.Height = 29;
            dataGridViewIngredientes.Size = new Size(822, 299);
            dataGridViewIngredientes.TabIndex = 20;
            // 
            // tabelaIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 591);
            Controls.Add(dataGridViewIngredientes);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaIngredientes";
            Text = "tabelaIngredientes";
            Load += tabelaIngredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private DataGridView dataGridViewIngredientes;
    }
}