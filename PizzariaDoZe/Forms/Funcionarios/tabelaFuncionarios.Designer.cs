﻿namespace PizzariaDoZe.Forms.Funcionarios
{
    partial class tabelaFuncionarios
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
            dataGridViewFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesquisa.Location = new Point(35, 29);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(89, 26);
            labelPesquisa.TabIndex = 15;
            labelPesquisa.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(40, 62);
            textBoxPesquisa.Margin = new Padding(3, 2, 3, 2);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(366, 31);
            textBoxPesquisa.TabIndex = 0;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(40, 140);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(730, 298);
            dataGridViewFuncionarios.TabIndex = 16;
            dataGridViewFuncionarios.CellFormatting += dataGridViewFuncionarios_CellFormatting;
            // 
            // tabelaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFuncionarios);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Name = "tabelaFuncionarios";
            Text = "Tabela funcionarios";
            Load += tabelaFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private DataGridView dataGridViewFuncionarios;
    }
}