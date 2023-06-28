namespace PizzariaDoZe.Forms.Pedidos
{
    partial class tabelaPedidos
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
            dataGridViewIngredientes = new DataGridView();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIngredientes
            // 
            dataGridViewIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredientes.Location = new Point(37, 187);
            dataGridViewIngredientes.Name = "dataGridViewIngredientes";
            dataGridViewIngredientes.RowHeadersWidth = 51;
            dataGridViewIngredientes.RowTemplate.Height = 29;
            dataGridViewIngredientes.Size = new Size(822, 299);
            dataGridViewIngredientes.TabIndex = 23;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(31, 35);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(112, 34);
            labelPesquisa.TabIndex = 22;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(37, 79);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(418, 37);
            textBoxPesquisa.TabIndex = 21;
            // 
            // tabelaPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 519);
            Controls.Add(dataGridViewIngredientes);
            Controls.Add(labelPesquisa);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaPedidos";
            Text = "tabelaPedidos";
            Load += tabelaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewIngredientes;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
    }
}