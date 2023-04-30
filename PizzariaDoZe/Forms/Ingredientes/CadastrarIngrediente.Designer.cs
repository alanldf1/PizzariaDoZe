namespace PizzariaDoZe.Forms.Ingredientes
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
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
            userControlRegister = new UserControlRegister();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(43, 170);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(537, 28);
            textBoxEmail.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(32, 134);
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
            textBoxName.TabIndex = 0;
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
            // userControlRegister
            // 
            userControlRegister.Location = new Point(68, 227);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(533, 113);
            userControlRegister.TabIndex = 25;
            // 
            // CadastrarIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 351);
            Controls.Add(userControlRegister);
            Controls.Add(textBoxEmail);
            Controls.Add(labelCod);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            KeyPreview = true;
            Name = "CadastrarIngrediente";
            Text = "Cadastro de Ingrediente";
            FormClosing += CadastrarIngrediente_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label labelCod;
        private TextBox textBoxName;
        private Label labelName;
        private UserControlRegister userControlRegister;
    }
}