namespace PizzariaDoZe.Forms.Produtos
{
    partial class CadastrarProdutos
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
            textBoxValor = new TextBox();
            textBoxNome = new TextBox();
            userControlRegister = new UserControlRegister();
            labelMl = new Label();
            listBoxML = new ListBox();
            labelTipo = new Label();
            listBoxTipo = new ListBox();
            labelName = new Label();
            labelValor = new Label();
            textBoxDescricao = new TextBox();
            labelDescricao = new Label();
            SuspendLayout();
            // 
            // textBoxValor
            // 
            textBoxValor.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValor.Location = new Point(32, 139);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(235, 28);
            textBoxValor.TabIndex = 114;
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(32, 50);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(235, 28);
            textBoxNome.TabIndex = 113;
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(132, 369);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(533, 113);
            userControlRegister.TabIndex = 112;
            // 
            // labelMl
            // 
            labelMl.AutoSize = true;
            labelMl.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelMl.Location = new Point(440, 194);
            labelMl.Name = "labelMl";
            labelMl.Size = new Size(33, 25);
            labelMl.TabIndex = 111;
            labelMl.Text = "ML:";
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Items.AddRange(new object[] { "150", "180", "300", "330", "390", "600", "660", "900", "1000", "1500", "2000", "2500", "3000" });
            listBoxML.Location = new Point(446, 222);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(309, 94);
            listBoxML.TabIndex = 110;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.Location = new Point(26, 194);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(44, 25);
            labelTipo.TabIndex = 109;
            labelTipo.Text = "Tipo:";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(32, 222);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(313, 94);
            listBoxTipo.TabIndex = 108;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(26, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 107;
            labelName.Text = "Nome:";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.Location = new Point(26, 99);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(50, 25);
            labelValor.TabIndex = 106;
            labelValor.Text = "Valor:";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescricao.Location = new Point(309, 50);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(446, 28);
            textBoxDescricao.TabIndex = 116;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.Location = new Point(303, 22);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(85, 25);
            labelDescricao.TabIndex = 115;
            labelDescricao.Text = "Descricao:";
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(textBoxDescricao);
            Controls.Add(labelDescricao);
            Controls.Add(textBoxValor);
            Controls.Add(textBoxNome);
            Controls.Add(userControlRegister);
            Controls.Add(labelMl);
            Controls.Add(listBoxML);
            Controls.Add(labelTipo);
            Controls.Add(listBoxTipo);
            Controls.Add(labelName);
            Controls.Add(labelValor);
            Name = "CadastrarProdutos";
            Text = "CadastrarProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValor;
        private TextBox textBoxNome;
        private UserControlRegister userControlRegister;
        private Label labelMl;
        private ListBox listBoxML;
        private Label labelTipo;
        private ListBox listBoxTipo;
        private Label labelName;
        private Label labelValor;
        private TextBox textBoxDescricao;
        private Label labelDescricao;
    }
}