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
            textBoxCpf.Location = new Point(43, 167);
            textBoxCpf.Margin = new Padding(3, 2, 3, 2);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(392, 28);
            textBoxCpf.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(37, 142);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(65, 25);
            labelCod.TabIndex = 24;
            labelCod.Text = "Código:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(43, 76);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(392, 28);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(37, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 18;
            labelName.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(532, 50);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 157);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // checkedListBoxIngredient
            // 
            checkedListBoxIngredient.ColumnWidth = 250;
            checkedListBoxIngredient.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxIngredient.FormattingEnabled = true;
            checkedListBoxIngredient.Items.AddRange(new object[] { "Margherita", "Pepperoni", "Frango com Catupiry", "Calabresa", "Quatro Queijos", "Portuguesa", "Muçarela", "Napolitana", "Atum", "Chocolate", "Banana com Canela", "Romeu e Julieta", "Brigadeiro", "Prestígio", "Mista" });
            checkedListBoxIngredient.Location = new Point(43, 274);
            checkedListBoxIngredient.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxIngredient.MultiColumn = true;
            checkedListBoxIngredient.Name = "checkedListBoxIngredient";
            checkedListBoxIngredient.Size = new Size(738, 136);
            checkedListBoxIngredient.TabIndex = 2;
            checkedListBoxIngredient.TabStop = false;
            // 
            // groupBoxCategoria
            // 
            groupBoxCategoria.Controls.Add(radioButtonEspecial);
            groupBoxCategoria.Controls.Add(radioButtonTradicional);
            groupBoxCategoria.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCategoria.Location = new Point(70, 454);
            groupBoxCategoria.Margin = new Padding(3, 2, 3, 2);
            groupBoxCategoria.Name = "groupBoxCategoria";
            groupBoxCategoria.Padding = new Padding(3, 2, 3, 2);
            groupBoxCategoria.Size = new Size(273, 70);
            groupBoxCategoria.TabIndex = 38;
            groupBoxCategoria.TabStop = false;
            groupBoxCategoria.Text = "Categoria";
            // 
            // radioButtonEspecial
            // 
            radioButtonEspecial.AutoSize = true;
            radioButtonEspecial.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonEspecial.Location = new Point(178, 30);
            radioButtonEspecial.Margin = new Padding(3, 2, 3, 2);
            radioButtonEspecial.Name = "radioButtonEspecial";
            radioButtonEspecial.Size = new Size(86, 29);
            radioButtonEspecial.TabIndex = 4;
            radioButtonEspecial.TabStop = true;
            radioButtonEspecial.Text = "Especial";
            radioButtonEspecial.UseVisualStyleBackColor = true;
            // 
            // radioButtonTradicional
            // 
            radioButtonTradicional.AutoSize = true;
            radioButtonTradicional.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTradicional.Location = new Point(22, 30);
            radioButtonTradicional.Margin = new Padding(3, 2, 3, 2);
            radioButtonTradicional.Name = "radioButtonTradicional";
            radioButtonTradicional.Size = new Size(106, 29);
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
            groupBox1.Location = new Point(460, 454);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(272, 70);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButtonDoce
            // 
            radioButtonDoce.AutoSize = true;
            radioButtonDoce.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDoce.Location = new Point(161, 30);
            radioButtonDoce.Margin = new Padding(3, 2, 3, 2);
            radioButtonDoce.Name = "radioButtonDoce";
            radioButtonDoce.Size = new Size(67, 29);
            radioButtonDoce.TabIndex = 6;
            radioButtonDoce.TabStop = true;
            radioButtonDoce.Text = "Doce";
            radioButtonDoce.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalgado
            // 
            radioButtonSalgado.AutoSize = true;
            radioButtonSalgado.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSalgado.Location = new Point(35, 30);
            radioButtonSalgado.Margin = new Padding(3, 2, 3, 2);
            radioButtonSalgado.Name = "radioButtonSalgado";
            radioButtonSalgado.Size = new Size(86, 29);
            radioButtonSalgado.TabIndex = 5;
            radioButtonSalgado.TabStop = true;
            radioButtonSalgado.Text = "Salgado";
            radioButtonSalgado.UseVisualStyleBackColor = true;
            // 
            // labelIngredient
            // 
            labelIngredient.AutoSize = true;
            labelIngredient.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredient.Location = new Point(37, 239);
            labelIngredient.Name = "labelIngredient";
            labelIngredient.Size = new Size(94, 25);
            labelIngredient.TabIndex = 40;
            labelIngredient.Text = "Ingrediente:";
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(137, 562);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(533, 99);
            userControlRegister.TabIndex = 41;
            // 
            // CadastrarSabor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(857, 705);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarSabor";
            Text = "CadastrarSabor";
            FormClosing += CadastrarSabor_FormClosing;
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