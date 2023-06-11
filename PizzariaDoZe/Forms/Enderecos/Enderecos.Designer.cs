namespace PizzariaDoZe.Forms.Enderecos
{
    partial class Enderecos
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
            dataGridViewEnderecos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnderecos).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(39, 30);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 19;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(44, 63);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 16;
            // 
            // dataGridViewEnderecos
            // 
            dataGridViewEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnderecos.Location = new Point(45, 179);
            dataGridViewEnderecos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEnderecos.Name = "dataGridViewEnderecos";
            dataGridViewEnderecos.RowHeadersWidth = 51;
            dataGridViewEnderecos.RowTemplate.Height = 29;
            dataGridViewEnderecos.Size = new Size(719, 224);
            dataGridViewEnderecos.TabIndex = 21;
            // 
            // Enderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEnderecos);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "Enderecos";
            Text = "Enderecos";
            Load += Enderecos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private DataGridView dataGridViewEnderecos;
    }
}