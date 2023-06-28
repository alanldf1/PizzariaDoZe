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
            dataGridViewPedidos = new DataGridView();
            labelPesquisa = new Label();
            textBoxPedidos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(43, 172);
            dataGridViewPedidos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewPedidos.RowTemplate.Height = 29;
            dataGridViewPedidos.Size = new Size(719, 224);
            dataGridViewPedidos.TabIndex = 23;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(38, 54);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 22;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // textBoxPedidos
            // 
            textBoxPedidos.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPedidos.Location = new Point(43, 87);
            textBoxPedidos.Margin = new Padding(3, 2, 3, 2);
            textBoxPedidos.Name = "textBoxPedidos";
            textBoxPedidos.Size = new Size(366, 31);
            textBoxPedidos.TabIndex = 21;
            // 
            // tabelaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewPedidos);
            Controls.Add(labelPesquisa);
            Controls.Add(textBoxPedidos);
            Name = "tabelaPedidos";
            Text = "tabelaPedidos";
            Load += tabelaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPedidos;
        private Label labelPesquisa;
        private TextBox textBoxPedidos;
    }
}