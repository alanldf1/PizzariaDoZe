namespace PizzariaDoZe.Forms.Clientes
{
    partial class tabelaClientes
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
            btnEnderecos = new Button();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(35, 26);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 18;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(40, 58);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 1;
            // 
            // btnEnderecos
            // 
            btnEnderecos.BackColor = Color.FromArgb(77, 10, 1);
            btnEnderecos.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnderecos.ForeColor = SystemColors.Control;
            btnEnderecos.Location = new Point(560, 56);
            btnEnderecos.Name = "btnEnderecos";
            btnEnderecos.Size = new Size(207, 39);
            btnEnderecos.TabIndex = 19;
            btnEnderecos.Text = "Enderecos";
            btnEnderecos.UseVisualStyleBackColor = false;
            btnEnderecos.Click += btnEnderecos_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(35, 143);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(732, 295);
            dataGridViewClientes.TabIndex = 20;
            // 
            // tabelaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnEnderecos);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaClientes";
            Text = "Tabela de Clientes";
            Load += tabelaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private Button btnEnderecos;
        private DataGridView dataGridViewClientes;
    }
}