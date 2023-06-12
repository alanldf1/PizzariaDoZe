namespace PizzariaDoZe.Forms.Produtos
{
    partial class tabelaProdutos
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
            dataGridViewProdutos = new DataGridView();
            labelPesquisa = new Label();
            label1 = new Label();
            textBoxPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(31, 144);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.Size = new Size(745, 290);
            dataGridViewProdutos.TabIndex = 28;
            dataGridViewProdutos.CellFormatting += dataGridViewProdutos_CellFormatting;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(25, 17);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 27;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 26;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(30, 50);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 25;
            // 
            // tabelaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaProdutos";
            Text = "tabelaProdutos";
            Load += tabelaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
    }
}