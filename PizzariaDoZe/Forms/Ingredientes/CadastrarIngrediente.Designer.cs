namespace PizzariaDoZe.Forms.Ingredientes
{
    partial class CadastrarIngrediente
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
            textBoxEmail = new TextBox();
            labelCod = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(43, 183);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(537, 28);
            textBoxEmail.TabIndex = 25;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(32, 147);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(65, 25);
            labelCod.TabIndex = 24;
            labelCod.Text = "Código:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(43, 86);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(537, 28);
            textBoxName.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(37, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 22;
            labelName.Text = "Nome:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(410, 293);
            btnCancel.Margin = new Padding(3, 10, 3, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 42);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(186, 293);
            btnRegister.Margin = new Padding(3, 10, 3, 10);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(194, 42);
            btnRegister.TabIndex = 28;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // CadastrarIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(textBoxEmail);
            Controls.Add(labelCod);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "CadastrarIngrediente";
            Text = "Cadastro de Ingrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label labelCod;
        private TextBox textBoxName;
        private Label labelName;
        private Button btnCancel;
        public Button btnRegister;
    }
}