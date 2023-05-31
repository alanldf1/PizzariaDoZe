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
            pictureBox1 = new PictureBox();
            checkedListBoxIngredient = new CheckedListBox();
            groupBoxCategoria = new GroupBox();
            radioButtonEspecial = new RadioButton();
            radioButtonTradicional = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonDoce = new RadioButton();
            radioButtonSalgado = new RadioButton();
            labelIngredient = new Label();
            userControlRegister = new UserControlRegister();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxCategoria.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCpf
            // 
            textBoxCpf.BorderStyle = BorderStyle.FixedSingle;
            textBoxCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(49, 223);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(448, 33);
            textBoxCpf.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(42, 189);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(78, 30);
            labelCod.TabIndex = 24;
            labelCod.Text = "Código:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(49, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(448, 33);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(42, 67);
            labelName.Name = "labelName";
            labelName.Size = new Size(69, 30);
            labelName.TabIndex = 18;
            labelName.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(608, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 209);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // checkedListBoxIngredient
            // 
            checkedListBoxIngredient.ColumnWidth = 250;
            checkedListBoxIngredient.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxIngredient.FormattingEnabled = true;
            checkedListBoxIngredient.Items.AddRange(new object[] { "Margherita", "Pepperoni", "Frango com Catupiry", "Calabresa", "Quatro Queijos", "Portuguesa", "Muçarela", "Napolitana", "Atum", "Chocolate", "Banana com Canela", "Romeu e Julieta", "Brigadeiro", "Prestígio", "Mista" });
            checkedListBoxIngredient.Location = new Point(49, 365);
            checkedListBoxIngredient.MultiColumn = true;
            checkedListBoxIngredient.Name = "checkedListBoxIngredient";
            checkedListBoxIngredient.Size = new Size(843, 166);
            checkedListBoxIngredient.TabIndex = 2;
            checkedListBoxIngredient.TabStop = false;
            // 
            // groupBoxCategoria
            // 
            groupBoxCategoria.Controls.Add(radioButtonEspecial);
            groupBoxCategoria.Controls.Add(radioButtonTradicional);
            groupBoxCategoria.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCategoria.Location = new Point(80, 605);
            groupBoxCategoria.Name = "groupBoxCategoria";
            groupBoxCategoria.Size = new Size(312, 93);
            groupBoxCategoria.TabIndex = 38;
            groupBoxCategoria.TabStop = false;
            groupBoxCategoria.Text = "Categoria";
            // 
            // radioButtonEspecial
            // 
            radioButtonEspecial.AutoSize = true;
            radioButtonEspecial.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonEspecial.Location = new Point(203, 40);
            radioButtonEspecial.Name = "radioButtonEspecial";
            radioButtonEspecial.Size = new Size(103, 34);
            radioButtonEspecial.TabIndex = 4;
            radioButtonEspecial.TabStop = true;
            radioButtonEspecial.Text = "Especial";
            radioButtonEspecial.UseVisualStyleBackColor = true;
            // 
            // radioButtonTradicional
            // 
            radioButtonTradicional.AutoSize = true;
            radioButtonTradicional.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTradicional.Location = new Point(25, 40);
            radioButtonTradicional.Name = "radioButtonTradicional";
            radioButtonTradicional.Size = new Size(126, 34);
            radioButtonTradicional.TabIndex = 3;
            radioButtonTradicional.TabStop = true;
            radioButtonTradicional.Text = "Tradicional";
            radioButtonTradicional.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonDoce);
            groupBox1.Controls.Add(radioButtonSalgado);
            groupBox1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(526, 605);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 93);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButtonDoce
            // 
            radioButtonDoce.AutoSize = true;
            radioButtonDoce.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDoce.Location = new Point(184, 40);
            radioButtonDoce.Name = "radioButtonDoce";
            radioButtonDoce.Size = new Size(78, 34);
            radioButtonDoce.TabIndex = 6;
            radioButtonDoce.TabStop = true;
            radioButtonDoce.Text = "Doce";
            radioButtonDoce.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalgado
            // 
            radioButtonSalgado.AutoSize = true;
            radioButtonSalgado.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSalgado.Location = new Point(40, 40);
            radioButtonSalgado.Name = "radioButtonSalgado";
            radioButtonSalgado.Size = new Size(103, 34);
            radioButtonSalgado.TabIndex = 5;
            radioButtonSalgado.TabStop = true;
            radioButtonSalgado.Text = "Salgado";
            radioButtonSalgado.UseVisualStyleBackColor = true;
            // 
            // labelIngredient
            // 
            labelIngredient.AutoSize = true;
            labelIngredient.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredient.Location = new Point(42, 319);
            labelIngredient.Name = "labelIngredient";
            labelIngredient.Size = new Size(114, 30);
            labelIngredient.TabIndex = 40;
            labelIngredient.Text = "Ingrediente:";
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(157, 749);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(609, 132);
            userControlRegister.TabIndex = 41;
            // 
            // CadastrarSabor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(979, 940);
            Controls.Add(userControlRegister);
            Controls.Add(labelIngredient);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCategoria);
            Controls.Add(checkedListBoxIngredient);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxCpf);
            Controls.Add(labelCod);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            KeyPreview = true;
            Name = "CadastrarSabor";
            Text = "CadastrarSabor";
            FormClosing += CadastrarSabor_FormClosing;
            Load += CadastrarSabor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxCategoria.ResumeLayout(false);
            groupBoxCategoria.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCpf;
        private Label labelCod;
        private TextBox textBoxName;
        private Label labelName;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBoxIngredient;
        private GroupBox groupBoxCategoria;
        private RadioButton radioButtonEspecial;
        private RadioButton radioButtonTradicional;
        private GroupBox groupBox1;
        private RadioButton radioButtonDoce;
        private RadioButton radioButtonSalgado;
        private Label labelIngredient;
        private UserControlRegister userControlRegister;
    }
}