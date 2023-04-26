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
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            theadCod = new Label();
            theadNome = new Label();
            theadId = new Label();
            btnEditar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-6, -28);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Controls.Add(theadCod, 2, 0);
            tableLayoutPanel1.Controls.Add(theadNome, 1, 0);
            tableLayoutPanel1.Controls.Add(theadId, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 5, 1);
            tableLayoutPanel1.Location = new Point(25, 112);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(720, 311);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(77, 10, 1);
            label6.Dock = DockStyle.Fill;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(538, 1);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(181, 30);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theadCod
            // 
            theadCod.AutoSize = true;
            theadCod.BackColor = Color.FromArgb(77, 10, 1);
            theadCod.Dock = DockStyle.Fill;
            theadCod.FlatStyle = FlatStyle.Flat;
            theadCod.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            theadCod.ForeColor = SystemColors.Control;
            theadCod.Location = new Point(359, 1);
            theadCod.Margin = new Padding(0);
            theadCod.Name = "theadCod";
            theadCod.Size = new Size(178, 30);
            theadCod.TabIndex = 2;
            theadCod.Text = "Código";
            theadCod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theadNome
            // 
            theadNome.AutoSize = true;
            theadNome.BackColor = Color.FromArgb(77, 10, 1);
            theadNome.Dock = DockStyle.Fill;
            theadNome.FlatStyle = FlatStyle.Flat;
            theadNome.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            theadNome.ForeColor = SystemColors.Control;
            theadNome.Location = new Point(180, 1);
            theadNome.Margin = new Padding(0);
            theadNome.Name = "theadNome";
            theadNome.Size = new Size(178, 30);
            theadNome.TabIndex = 1;
            theadNome.Text = "Nome";
            theadNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theadId
            // 
            theadId.AutoSize = true;
            theadId.BackColor = Color.FromArgb(77, 10, 1);
            theadId.Dock = DockStyle.Fill;
            theadId.FlatStyle = FlatStyle.Flat;
            theadId.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            theadId.ForeColor = SystemColors.Control;
            theadId.Location = new Point(1, 1);
            theadId.Margin = new Padding(0);
            theadId.Name = "theadId";
            theadId.Size = new Size(178, 30);
            theadId.TabIndex = 0;
            theadId.Text = "Id";
            theadId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(66, 133, 244);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(543, 33);
            btnEditar.Margin = new Padding(5, 1, 5, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(171, 28);
            btnEditar.TabIndex = 1;
            btnEditar.TabStop = false;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // tabelaIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 443);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisa);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tabelaIngredientes";
            Text = "tabelaIngredientes";
            Load += tabelaIngredientes_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private Label label1;
        private TextBox textBoxPesquisa;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label theadNome;
        private Label theadId;
        private Button btnEditar;
        private Label theadCod;
    }
}