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
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            theadNome = new Label();
            theadId = new Label();
            btnEditar = new Button();
            theadCod = new Label();
            tableLayoutPanel1.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(29, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 37);
            textBox1.TabIndex = 17;
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
            tableLayoutPanel1.Location = new Point(29, 149);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
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
            tableLayoutPanel1.Size = new Size(823, 415);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(77, 10, 1);
            label6.Dock = DockStyle.Fill;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(616, 1);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(206, 40);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theadNome
            // 
            theadNome.AutoSize = true;
            theadNome.BackColor = Color.FromArgb(77, 10, 1);
            theadNome.Dock = DockStyle.Fill;
            theadNome.FlatStyle = FlatStyle.Flat;
            theadNome.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            theadNome.ForeColor = SystemColors.Control;
            theadNome.Location = new Point(206, 1);
            theadNome.Margin = new Padding(0);
            theadNome.Name = "theadNome";
            theadNome.Size = new Size(204, 40);
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
            theadId.Size = new Size(204, 40);
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
            btnEditar.Location = new Point(622, 43);
            btnEditar.Margin = new Padding(6, 1, 6, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(194, 38);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // theadCod
            // 
            theadCod.AutoSize = true;
            theadCod.BackColor = Color.FromArgb(77, 10, 1);
            theadCod.Dock = DockStyle.Fill;
            theadCod.FlatStyle = FlatStyle.Flat;
            theadCod.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            theadCod.ForeColor = SystemColors.Control;
            theadCod.Location = new Point(411, 1);
            theadCod.Margin = new Padding(0);
            theadCod.Name = "theadCod";
            theadCod.Size = new Size(204, 40);
            theadCod.TabIndex = 2;
            theadCod.Text = "Código";
            theadCod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabelaIngredientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 591);
            Controls.Add(labelPesquisa);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
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
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label theadNome;
        private Label theadId;
        private Button btnEditar;
        private Label theadCod;
    }
}