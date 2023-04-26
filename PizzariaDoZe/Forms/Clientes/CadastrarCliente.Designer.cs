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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxCpf = new TextBox();
            labelCpf = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            textBoxCep = new TextBox();
            labelCep = new Label();
            textBoxEndereco = new TextBox();
            labelEndereco = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxNumero = new TextBox();
            labelNumber = new Label();
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
            // textBoxPhone
            // 
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(27, 193);
            textBoxPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(338, 28);
            textBoxPhone.TabIndex = 3;
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
            // textBoxCpf
            // 
            textBoxCpf.BorderStyle = BorderStyle.FixedSingle;
            textBoxCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(382, 53);
            textBoxCpf.Margin = new Padding(3, 2, 3, 2);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(276, 28);
            textBoxCpf.TabIndex = 1;
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
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(420, 512);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(194, 42);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(68, 512);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 42);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBoxCep
            // 
            textBoxCep.BorderStyle = BorderStyle.FixedSingle;
            textBoxCep.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCep.Location = new Point(27, 270);
            textBoxCep.Margin = new Padding(3, 2, 3, 2);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(282, 28);
            textBoxCep.TabIndex = 4;
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
            textBoxComplemento.TextChanged += textBoxComplemento_TextChanged;
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
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 25);
            ClientSize = new Size(700, 587);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumber);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxEndereco);
            Controls.Add(labelEndereco);
            Controls.Add(textBoxCep);
            Controls.Add(labelCep);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(textBoxCpf);
            Controls.Add(labelCpf);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarCliente";
            Text = "Cadastrar cliente";
            Load += CadastrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxCpf;
        private Label labelCpf;
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public Button btnRegister;
        private Button btnCancel;
        private TextBox textBoxCep;
        private Label labelCep;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxNumero;
        private Label labelNumber;
        private TextBox textBoxEndereco;
        private Label labelEndereco;
    }
}