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
            textBoxName = new TextBox();
            labelName = new Label();
            userControlRegister = new UserControlRegister();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(51, 132);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(613, 33);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(44, 82);
            labelName.Name = "labelName";
            labelName.Size = new Size(69, 30);
            labelName.TabIndex = 22;
            labelName.Text = "Nome:";
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(77, 218);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(609, 151);
            userControlRegister.TabIndex = 25;
            // 
            // CadastrarIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 390);
            Controls.Add(userControlRegister);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastrarIngrediente";
            Text = "Cadastro de Ingrediente";
            FormClosing += CadastrarIngrediente_FormClosing;
            Load += CadastrarIngrediente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private Label labelName;
        private UserControlRegister userControlRegister;
    }
}