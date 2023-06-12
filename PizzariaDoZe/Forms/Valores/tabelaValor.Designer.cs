namespace PizzariaDoZe.Forms.Valores
{
    partial class tabelaValor
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
            dataGridViewValores = new DataGridView();
            labelPesquisa = new Label();
            label1 = new Label();
            textBoxPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewValores
            // 
            dataGridViewValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewValores.Location = new Point(25, 148);
            dataGridViewValores.Name = "dataGridViewValores";
            dataGridViewValores.RowTemplate.Height = 25;
            dataGridViewValores.Size = new Size(745, 290);
            dataGridViewValores.TabIndex = 24;
            dataGridViewValores.CellFormatting += dataGridViewValores_CellFormatting;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(19, 21);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 23;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 22;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(24, 54);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 21;
            // 
            // tabelaValor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewValores);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaValor";
            Text = "tabelaValor";
            Load += tabelaValor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewValores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewValores;
        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
    }
}