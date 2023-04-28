namespace PizzariaDoZe
{
    partial class UserControlRegister
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(26, 40);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(222, 56);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(356, 40);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(222, 56);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // UserControlRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Name = "UserControlRegister";
            Size = new Size(609, 151);
            ResumeLayout(false);
        }

        #endregion
        public Button btnRegister;
        public Button btnCancel;
    }
}
