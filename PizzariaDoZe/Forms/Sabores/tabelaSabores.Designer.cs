namespace PizzariaDoZe.Forms.Sabores
{
    partial class tabelaSabores
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
            dataGridViewSabores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(21, 21);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 19;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(26, 54);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 0;
            // 
            // dataGridViewSabores
            // 
            dataGridViewSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSabores.Location = new Point(27, 148);
            dataGridViewSabores.Name = "dataGridViewSabores";
            dataGridViewSabores.RowTemplate.Height = 25;
            dataGridViewSabores.Size = new Size(745, 290);
            dataGridViewSabores.TabIndex = 20;
            dataGridViewSabores.CellFormatting += dataGridViewSabores_CellFormatting;
            // 
            // tabelaSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(784, 450);
            Controls.Add(dataGridViewSabores);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tabelaSabores";
            Text = "tabelaSabores";
            Load += tabelaSabores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSabores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private DataGridView dataGridViewSabores;
    }
}