namespace PizzariaDoZe.Forms.Sabores
{
    partial class CadastrarSabor
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
            textBoxCpf = new TextBox();
            labelCod = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            pictureBoxImagem = new PictureBox();
            checkedListBoxIngredient = new CheckedListBox();
            labelIngredient = new Label();
            userControlRegister = new UserControlRegister();
            label1 = new Label();
            listBoxCategoria = new ListBox();
            labelCategoria = new Label();
            labelTipo = new Label();
            listBoxTipo = new ListBox();
            labelDescricao = new Label();
            textBoxDescricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // textBoxCpf
            // 
            textBoxCpf.BorderStyle = BorderStyle.FixedSingle;
            textBoxCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(43, 76);
            textBoxCpf.Margin = new Padding(3, 2, 3, 2);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(392, 28);
            textBoxCpf.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(37, 51);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(65, 25);
            labelCod.TabIndex = 24;
            labelCod.Text = "Código:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(43, 154);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(392, 28);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(37, 128);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 18;
            labelName.Text = "Nome:";
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = Properties.Resources.picture1;
            pictureBoxImagem.InitialImage = null;
            pictureBoxImagem.Location = new Point(531, 76);
            pictureBoxImagem.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(210, 145);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 36;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // checkedListBoxIngredient
            // 
            checkedListBoxIngredient.ColumnWidth = 250;
            checkedListBoxIngredient.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxIngredient.FormattingEnabled = true;
            checkedListBoxIngredient.Items.AddRange(new object[] { "Margherita", "Pepperoni", "Frango com Catupiry", "Calabresa", "Quatro Queijos", "Portuguesa", "Muçarela", "Napolitana", "Atum", "Chocolate", "Banana com Canela", "Romeu e Julieta", "Brigadeiro", "Prestígio", "Mista" });
            checkedListBoxIngredient.Location = new Point(43, 419);
            checkedListBoxIngredient.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxIngredient.MultiColumn = true;
            checkedListBoxIngredient.Name = "checkedListBoxIngredient";
            checkedListBoxIngredient.Size = new Size(738, 114);
            checkedListBoxIngredient.TabIndex = 2;
            checkedListBoxIngredient.TabStop = false;
            // 
            // labelIngredient
            // 
            labelIngredient.AutoSize = true;
            labelIngredient.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredient.Location = new Point(37, 384);
            labelIngredient.Name = "labelIngredient";
            labelIngredient.Size = new Size(94, 25);
            labelIngredient.TabIndex = 40;
            labelIngredient.Text = "Ingrediente:";
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(135, 695);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(533, 99);
            userControlRegister.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(520, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 42;
            label1.Text = "Foto:";
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(102, 596);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(228, 94);
            listBoxCategoria.TabIndex = 43;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoria.Location = new Point(96, 568);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(84, 25);
            labelCategoria.TabIndex = 44;
            labelCategoria.Text = "Categoria:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.Location = new Point(466, 568);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(44, 25);
            labelTipo.TabIndex = 46;
            labelTipo.Text = "Tipo:";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(472, 596);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(228, 94);
            listBoxTipo.TabIndex = 45;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.Location = new Point(37, 217);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(85, 25);
            labelDescricao.TabIndex = 91;
            labelDescricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricao.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescricao.Location = new Point(43, 243);
            textBoxDescricao.Margin = new Padding(3, 2, 3, 2);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(392, 102);
            textBoxDescricao.TabIndex = 90;
            // 
            // CadastrarSabor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(857, 850);
            Controls.Add(labelDescricao);
            Controls.Add(textBoxDescricao);
            Controls.Add(labelTipo);
            Controls.Add(listBoxTipo);
            Controls.Add(labelCategoria);
            Controls.Add(listBoxCategoria);
            Controls.Add(label1);
            Controls.Add(userControlRegister);
            Controls.Add(labelIngredient);
            Controls.Add(checkedListBoxIngredient);
            Controls.Add(pictureBoxImagem);
            Controls.Add(textBoxCpf);
            Controls.Add(labelCod);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarSabor";
            Text = "CadastrarSabor";
            FormClosing += CadastrarSabor_FormClosing;
            Load += CadastrarSabor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCpf;
        private Label labelCod;
        private TextBox textBoxName;
        private Label labelName;
        private PictureBox pictureBoxImagem;
        private CheckedListBox checkedListBoxIngredient;
        private Label labelIngredient;
        private UserControlRegister userControlRegister;
        private Label label1;
        private ListBox listBoxCategoria;
        private Label labelCategoria;
        private Label labelTipo;
        private ListBox listBoxTipo;
        private Label labelDescricao;
        private TextBox textBoxDescricao;
    }
}