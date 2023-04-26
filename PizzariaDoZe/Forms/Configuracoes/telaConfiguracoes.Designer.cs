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
            tabControl1.SuspendLayout();
            tabPageLanguage.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tabControl1.Location = new Point(24, 58);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(723, 320);
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            // 
            // tabPageLanguage
            // 
            tabPageLanguage.Controls.Add(buttonSalvarLinguagem);
            tabPageLanguage.Controls.Add(groupBox1);
            tabPageLanguage.Location = new Point(4, 31);
            tabPageLanguage.Margin = new Padding(3, 2, 3, 2);
            tabPageLanguage.Name = "tabPageLanguage";
            tabPageLanguage.Padding = new Padding(3, 2, 3, 2);
            tabPageLanguage.Size = new Size(715, 285);
            tabPageLanguage.TabIndex = 0;
            tabPageLanguage.Text = "Idioma/Linguagem";
            tabPageLanguage.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarLinguagem
            // 
            buttonSalvarLinguagem.BackColor = Color.FromArgb(0, 192, 0);
            buttonSalvarLinguagem.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvarLinguagem.ForeColor = Color.White;
            buttonSalvarLinguagem.Location = new Point(542, 238);
            buttonSalvarLinguagem.Margin = new Padding(3, 2, 3, 2);
            buttonSalvarLinguagem.Name = "buttonSalvarLinguagem";
            buttonSalvarLinguagem.Size = new Size(122, 37);
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
            groupBox1.Location = new Point(24, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(615, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Idioma/Linguagem";
            // 
            // checkBoxApplyNow
            // 
            checkBoxApplyNow.AutoSize = true;
            checkBoxApplyNow.Location = new Point(214, 54);
            checkBoxApplyNow.Margin = new Padding(3, 2, 3, 2);
            checkBoxApplyNow.Name = "checkBoxApplyNow";
            checkBoxApplyNow.Size = new Size(361, 26);
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
            comboBoxLanguage.Location = new Point(24, 52);
            comboBoxLanguage.Margin = new Padding(3, 2, 3, 2);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(171, 30);
            comboBoxLanguage.TabIndex = 1;
            // 
            // labelSelectLanguage
            // 
            labelSelectLanguage.AutoSize = true;
            labelSelectLanguage.Location = new Point(24, 31);
            labelSelectLanguage.Name = "labelSelectLanguage";
            labelSelectLanguage.Size = new Size(146, 22);
            labelSelectLanguage.TabIndex = 0;
            labelSelectLanguage.Text = "Selecione a linguagem";
            // 
            // tabPageLog
            // 
            tabPageLog.Location = new Point(4, 31);
            tabPageLog.Margin = new Padding(3, 2, 3, 2);
            tabPageLog.Name = "tabPageLog";
            tabPageLog.Padding = new Padding(3, 2, 3, 2);
            tabPageLog.Size = new Size(715, 285);
            tabPageLog.TabIndex = 1;
            tabPageLog.Text = "Armazenamento LOG";
            tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabPageExit
            // 
            tabPageExit.Location = new Point(4, 31);
            tabPageExit.Margin = new Padding(3, 2, 3, 2);
            tabPageExit.Name = "tabPageExit";
            tabPageExit.Size = new Size(715, 285);
            tabPageExit.TabIndex = 2;
            tabPageExit.Text = "Fechar ao sair";
            tabPageExit.UseVisualStyleBackColor = true;
            // 
            // tabPageCharge
            // 
            tabPageCharge.Location = new Point(4, 31);
            tabPageCharge.Margin = new Padding(3, 2, 3, 2);
            tabPageCharge.Name = "tabPageCharge";
            tabPageCharge.Size = new Size(715, 285);
            tabPageCharge.TabIndex = 3;
            tabPageCharge.Text = "Parâmetros para cobrança";
            tabPageCharge.UseVisualStyleBackColor = true;
            // 
            // tabPageDataBase
            // 
            tabPageDataBase.Location = new Point(4, 31);
            tabPageDataBase.Margin = new Padding(3, 2, 3, 2);
            tabPageDataBase.Name = "tabPageDataBase";
            tabPageDataBase.Size = new Size(715, 285);
            tabPageDataBase.TabIndex = 4;
            tabPageDataBase.Text = "Banco de dados";
            tabPageDataBase.UseVisualStyleBackColor = true;
            // 
            // telaConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 387);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "telaConfiguracoes";
            Text = "Configurações";
            Load += telaConfiguracoes_Load;
            tabControl1.ResumeLayout(false);
            tabPageLanguage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
    }
}