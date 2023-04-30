namespace PizzariaDoZe.Forms.Clientes
{
    partial class CadastrarCliente
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
            labelName = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPhone = new Label();
            labelCpf = new Label();
            labelCep = new Label();
            textBoxEndereco = new TextBox();
            labelEndereco = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxNumero = new TextBox();
            labelNumber = new Label();
            userControlRegister = new UserControlRegister();
            textBoxName = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxPhone = new MaskedTextBox();
            maskedTextBoxCep = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(21, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(57, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Nome:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(27, 120);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(474, 28);
            textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(21, 94);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(21, 167);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(76, 25);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Telefone:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(376, 28);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(41, 25);
            labelCpf.TabIndex = 6;
            labelCpf.Text = "CPF:";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCep.Location = new Point(21, 244);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(41, 25);
            labelCep.TabIndex = 10;
            labelCep.Text = "CEP:";
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.BorderStyle = BorderStyle.FixedSingle;
            textBoxEndereco.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEndereco.Location = new Point(27, 347);
            textBoxEndereco.Margin = new Padding(3, 2, 3, 2);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(610, 28);
            textBoxEndereco.TabIndex = 5;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereco.Location = new Point(21, 321);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(81, 25);
            labelEndereco.TabIndex = 12;
            labelEndereco.Text = "Endereço:";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.BorderStyle = BorderStyle.FixedSingle;
            textBoxComplemento.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComplemento.Location = new Point(382, 423);
            textBoxComplemento.Margin = new Padding(3, 2, 3, 2);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(282, 28);
            textBoxComplemento.TabIndex = 7;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelComplemento.Location = new Point(376, 397);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(116, 25);
            labelComplemento.TabIndex = 14;
            labelComplemento.Text = "Complemento:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumero.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumero.Location = new Point(27, 423);
            textBoxNumero.Margin = new Padding(3, 2, 3, 2);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(282, 28);
            textBoxNumero.TabIndex = 6;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(21, 397);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(71, 25);
            labelNumber.TabIndex = 16;
            labelNumber.Text = "Número:";
            // 
            // userControlRegister
            // 
            userControlRegister.Location = new Point(67, 503);
            userControlRegister.Margin = new Padding(3, 2, 3, 2);
            userControlRegister.Name = "userControlRegister";
            userControlRegister.Size = new Size(539, 109);
            userControlRegister.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(27, 53);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(255, 28);
            textBoxName.TabIndex = 0;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpf.Location = new Point(382, 56);
            maskedTextBoxCpf.Mask = " 000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(282, 28);
            maskedTextBoxCpf.TabIndex = 1;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPhone.Location = new Point(27, 195);
            maskedTextBoxPhone.Mask = "(00) 90000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(255, 28);
            maskedTextBoxPhone.TabIndex = 3;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.AllowDrop = true;
            maskedTextBoxCep.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCep.Location = new Point(27, 272);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(255, 28);
            maskedTextBoxCep.TabIndex = 4;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 25);
            ClientSize = new Size(700, 638);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(userControlRegister);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumber);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxEndereco);
            Controls.Add(labelEndereco);
            Controls.Add(labelCep);
            Controls.Add(labelCpf);
            Controls.Add(labelPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarCliente";
            Text = "Cadastrar cliente";
            FormClosing += CadastrarCliente_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelCpf;
        private Label labelCep;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxNumero;
        private Label labelNumber;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
        private UserControlRegister userControlRegister;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxPhone;
        private MaskedTextBox maskedTextBoxCep;
    }
}