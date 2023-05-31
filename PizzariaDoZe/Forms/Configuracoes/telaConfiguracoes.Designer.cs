namespace PizzariaDoZe.Forms.Configuracoes
{
    partial class telaConfiguracoes
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
            tabControl1 = new TabControl();
            tabPageLanguage = new TabPage();
            buttonSalvarLinguagem = new Button();
            groupBox1 = new GroupBox();
            checkBoxApplyNow = new CheckBox();
            comboBoxLanguage = new ComboBox();
            labelSelectLanguage = new Label();
            tabPageLog = new TabPage();
            tabPageExit = new TabPage();
            tabPageCharge = new TabPage();
            tabPageDataBase = new TabPage();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonSaveBd = new Button();
            textBoxStringDeConexao = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxProvider = new ComboBox();
            tabControl1.SuspendLayout();
            tabPageLanguage.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageDataBase.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLanguage);
            tabControl1.Controls.Add(tabPageLog);
            tabControl1.Controls.Add(tabPageExit);
            tabControl1.Controls.Add(tabPageCharge);
            tabControl1.Controls.Add(tabPageDataBase);
            tabControl1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 427);
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            // 
            // tabPageLanguage
            // 
            tabPageLanguage.Controls.Add(buttonSalvarLinguagem);
            tabPageLanguage.Controls.Add(groupBox1);
            tabPageLanguage.Location = new Point(4, 35);
            tabPageLanguage.Name = "tabPageLanguage";
            tabPageLanguage.Padding = new Padding(3);
            tabPageLanguage.Size = new Size(818, 388);
            tabPageLanguage.TabIndex = 0;
            tabPageLanguage.Text = "Idioma/Linguagem";
            tabPageLanguage.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarLinguagem
            // 
            buttonSalvarLinguagem.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarLinguagem.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvarLinguagem.ForeColor = Color.White;
            buttonSalvarLinguagem.Location = new Point(619, 317);
            buttonSalvarLinguagem.Name = "buttonSalvarLinguagem";
            buttonSalvarLinguagem.Size = new Size(139, 49);
            buttonSalvarLinguagem.TabIndex = 1;
            buttonSalvarLinguagem.Text = "Salvar";
            buttonSalvarLinguagem.UseVisualStyleBackColor = false;
            buttonSalvarLinguagem.Click += ButtonSalvarLinguagem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxApplyNow);
            groupBox1.Controls.Add(comboBoxLanguage);
            groupBox1.Controls.Add(labelSelectLanguage);
            groupBox1.Location = new Point(27, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Idioma/Linguagem";
            // 
            // checkBoxApplyNow
            // 
            checkBoxApplyNow.AutoSize = true;
            checkBoxApplyNow.Location = new Point(245, 72);
            checkBoxApplyNow.Name = "checkBoxApplyNow";
            checkBoxApplyNow.Size = new Size(457, 30);
            checkBoxApplyNow.TabIndex = 2;
            checkBoxApplyNow.Text = "Reiniciar para aplicar a nova linguagem imediatamente";
            checkBoxApplyNow.UseVisualStyleBackColor = true;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.AutoCompleteCustomSource.AddRange(new string[] { "pt-BR", "en-US", "es" });
            comboBoxLanguage.Cursor = Cursors.Hand;
            comboBoxLanguage.DisplayMember = "pt-BR";
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxLanguage.Location = new Point(27, 69);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(195, 34);
            comboBoxLanguage.TabIndex = 1;
            // 
            // labelSelectLanguage
            // 
            labelSelectLanguage.AutoSize = true;
            labelSelectLanguage.Location = new Point(27, 41);
            labelSelectLanguage.Name = "labelSelectLanguage";
            labelSelectLanguage.Size = new Size(185, 26);
            labelSelectLanguage.TabIndex = 0;
            labelSelectLanguage.Text = "Selecione a linguagem";
            // 
            // tabPageLog
            // 
            tabPageLog.Location = new Point(4, 35);
            tabPageLog.Name = "tabPageLog";
            tabPageLog.Padding = new Padding(3);
            tabPageLog.Size = new Size(818, 388);
            tabPageLog.TabIndex = 1;
            tabPageLog.Text = "Armazenamento LOG";
            tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabPageExit
            // 
            tabPageExit.Location = new Point(4, 35);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Size = new Size(818, 388);
            tabPageExit.TabIndex = 2;
            tabPageExit.Text = "Fechar ao sair";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // tabPageCharge
            // 
            tabPageCharge.Location = new Point(4, 35);
            tabPageCharge.Name = "tabPageCharge";
            tabPageCharge.Size = new Size(818, 388);
            tabPageCharge.TabIndex = 3;
            tabPageCharge.Text = "Parâmetros para cobrança";
            tabPageCharge.UseVisualStyleBackColor = true;
            // 
            // tabPageDataBase
            // 
            tabPageDataBase.Controls.Add(label5);
            tabPageDataBase.Controls.Add(label6);
            tabPageDataBase.Controls.Add(label4);
            tabPageDataBase.Controls.Add(label3);
            tabPageDataBase.Controls.Add(buttonSaveBd);
            tabPageDataBase.Controls.Add(textBoxStringDeConexao);
            tabPageDataBase.Controls.Add(label2);
            tabPageDataBase.Controls.Add(label1);
            tabPageDataBase.Controls.Add(comboBoxProvider);
            tabPageDataBase.Location = new Point(4, 35);
            tabPageDataBase.Name = "tabPageDataBase";
            tabPageDataBase.Size = new Size(818, 388);
            tabPageDataBase.TabIndex = 4;
            tabPageDataBase.Text = "Banco de dados";
            tabPageDataBase.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 303);
            label5.Name = "label5";
            label5.Size = new Size(101, 30);
            label5.TabIndex = 8;
            label5.Text = "SQLServer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 333);
            label6.MaximumSize = new Size(610, 0);
            label6.Name = "label6";
            label6.Size = new Size(519, 52);
            label6.TabIndex = 7;
            label6.Text = "server=BILL-CIPHER\\UNIPLAC; initial catalog=pizzaria_ze;integrated security=true; user id=BILL-CIPHER\\alan_;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 238);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 6;
            label4.Text = "MySQL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 268);
            label3.Name = "label3";
            label3.Size = new Size(433, 26);
            label3.TabIndex = 5;
            label3.Text = "Server=localhost;Database=pizzaria_ze;Uid=root;Pwd=;";
            // 
            // buttonSaveBd
            // 
            buttonSaveBd.BackColor = Color.FromArgb(0, 192, 0);
            buttonSaveBd.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveBd.ForeColor = Color.White;
            buttonSaveBd.Location = new Point(653, 322);
            buttonSaveBd.Name = "buttonSaveBd";
            buttonSaveBd.Size = new Size(139, 49);
            buttonSaveBd.TabIndex = 4;
            buttonSaveBd.Text = "Salvar";
            buttonSaveBd.UseVisualStyleBackColor = false;
            buttonSaveBd.Click += buttonSaveBd_Click;
            // 
            // textBoxStringDeConexao
            // 
            textBoxStringDeConexao.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStringDeConexao.Location = new Point(47, 178);
            textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            textBoxStringDeConexao.Size = new Size(496, 32);
            textBoxStringDeConexao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 145);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 2;
            label2.Text = "String de conexão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 1;
            label1.Text = "Provider";
            label1.Click += label1_Click;
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "MySql.Data.MySqlClient", "System.Data.SqlClient" });
            comboBoxProvider.Location = new Point(47, 61);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(225, 34);
            comboBoxProvider.TabIndex = 0;
            // 
            // telaConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 516);
            Controls.Add(tabControl1);
            Name = "telaConfiguracoes";
            Text = "Configurações";
            Load += telaConfiguracoes_Load;
            tabControl1.ResumeLayout(false);
            tabPageLanguage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageDataBase.ResumeLayout(false);
            tabPageDataBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageLanguage;
        private Button buttonSalvarLinguagem;
        private GroupBox groupBox1;
        private CheckBox checkBoxApplyNow;
        private ComboBox comboBoxLanguage;
        private Label labelSelectLanguage;
        private TabPage tabPageLog;
        private TabPage tabPageExit;
        private TabPage tabPageCharge;
        private TabPage tabPageDataBase;
        private Label label1;
        private ComboBox comboBoxProvider;
        private TextBox textBoxStringDeConexao;
        private Label label2;
        private Button buttonSaveBd;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        public TabControl tabControl1;
    }
}