namespace PizzariaDoZe
{
    /// <summary>
    /// Sistema principal
    /// </summary>
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnConfiguracoes = new Button();
            btnIngredientes = new Button();
            btnSabores = new Button();
            btnFuncionarios = new Button();
            btnClientes = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            labelUserLogged = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnInvisible = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(76, 10, 1);
            panelMenu.Controls.Add(btnConfiguracoes);
            panelMenu.Controls.Add(btnIngredientes);
            panelMenu.Controls.Add(btnSabores);
            panelMenu.Controls.Add(btnFuncionarios);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 691);
            panelMenu.TabIndex = 0;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.Dock = DockStyle.Top;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracoes.ForeColor = Color.Gainsboro;
            btnConfiguracoes.Image = Properties.Resources.configuracoes;
            btnConfiguracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.Location = new Point(0, 499);
            btnConfiguracoes.Margin = new Padding(3, 4, 3, 4);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(11, 0, 0, 0);
            btnConfiguracoes.Size = new Size(251, 80);
            btnConfiguracoes.TabIndex = 6;
            btnConfiguracoes.Tag = "Configuracoes";
            btnConfiguracoes.Text = "   Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracoes.UseVisualStyleBackColor = true;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnIngredientes
            // 
            btnIngredientes.Dock = DockStyle.Top;
            btnIngredientes.FlatAppearance.BorderSize = 0;
            btnIngredientes.FlatStyle = FlatStyle.Flat;
            btnIngredientes.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngredientes.ForeColor = Color.Gainsboro;
            btnIngredientes.Image = Properties.Resources.ingredientes;
            btnIngredientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngredientes.Location = new Point(0, 419);
            btnIngredientes.Margin = new Padding(3, 4, 3, 4);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Padding = new Padding(11, 0, 0, 0);
            btnIngredientes.Size = new Size(251, 80);
            btnIngredientes.TabIndex = 5;
            btnIngredientes.Tag = "Ingredientes";
            btnIngredientes.Text = "   Ingredientes";
            btnIngredientes.TextAlign = ContentAlignment.MiddleLeft;
            btnIngredientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngredientes.UseVisualStyleBackColor = true;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnSabores
            // 
            btnSabores.Dock = DockStyle.Top;
            btnSabores.FlatAppearance.BorderSize = 0;
            btnSabores.FlatStyle = FlatStyle.Flat;
            btnSabores.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSabores.ForeColor = Color.Gainsboro;
            btnSabores.Image = Properties.Resources.sabores;
            btnSabores.ImageAlign = ContentAlignment.MiddleLeft;
            btnSabores.Location = new Point(0, 339);
            btnSabores.Margin = new Padding(3, 4, 3, 4);
            btnSabores.Name = "btnSabores";
            btnSabores.Padding = new Padding(11, 0, 0, 0);
            btnSabores.Size = new Size(251, 80);
            btnSabores.TabIndex = 4;
            btnSabores.Tag = "Sabores";
            btnSabores.Text = "   Sabores";
            btnSabores.TextAlign = ContentAlignment.MiddleLeft;
            btnSabores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSabores.UseVisualStyleBackColor = true;
            btnSabores.Click += btnSabores_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarios.ForeColor = Color.Gainsboro;
            btnFuncionarios.Image = Properties.Resources.funcionarios;
            btnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.Location = new Point(0, 259);
            btnFuncionarios.Margin = new Padding(3, 4, 3, 4);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(11, 0, 0, 0);
            btnFuncionarios.Size = new Size(251, 80);
            btnFuncionarios.TabIndex = 3;
            btnFuncionarios.Tag = "Funcionarios";
            btnFuncionarios.Text = "   Funcionarios";
            btnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.Gainsboro;
            btnClientes.Image = Properties.Resources.clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 179);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(11, 0, 0, 0);
            btnClientes.Size = new Size(251, 80);
            btnClientes.TabIndex = 2;
            btnClientes.Tag = "Clientes";
            btnClientes.Text = "   Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Gainsboro;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(76, 10, 1);
            btnHome.Image = Properties.Resources.home_red;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 99);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(11, 0, 0, 0);
            btnHome.Size = new Size(251, 80);
            btnHome.TabIndex = 1;
            btnHome.Tag = "Home";
            btnHome.Text = "   Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(50, 6, 0);
            panelLogo.Controls.Add(labelUserLogged);
            panelLogo.Controls.Add(panel1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = Color.Gainsboro;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 99);
            panelLogo.TabIndex = 0;
            // 
            // labelUserLogged
            // 
            labelUserLogged.AutoSize = true;
            labelUserLogged.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserLogged.Location = new Point(14, 35);
            labelUserLogged.Name = "labelUserLogged";
            labelUserLogged.Size = new Size(78, 34);
            labelUserLogged.TabIndex = 2;
            labelUserLogged.Text = "Admin";
            // 
            // panel1
            // 
            panel1.Location = new Point(249, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 133);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnInvisible);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(251, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 99);
            panel2.TabIndex = 1;
            // 
            // btnInvisible
            // 
            btnInvisible.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInvisible.BackColor = Color.FromArgb(0, 192, 0);
            btnInvisible.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvisible.ForeColor = Color.White;
            btnInvisible.Location = new Point(635, 18);
            btnInvisible.Name = "btnInvisible";
            btnInvisible.Size = new Size(282, 69);
            btnInvisible.TabIndex = 1;
            btnInvisible.Text = "Cadastrar";
            btnInvisible.UseVisualStyleBackColor = false;
            btnInvisible.Visible = false;
            btnInvisible.Click += btnInvisible_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bem vindo a home";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Location = new Point(251, 99);
            panelDesktopPane.Margin = new Padding(3, 4, 3, 4);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(946, 592);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1197, 691);
            Controls.Add(panelDesktopPane);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMainMenu";
            Text = "Pizzaria do Zé";
            FormClosing += FormMainMenu_FormClosing;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Panel panelLogo;
        private Button btnIngredientes;
        private Button btnSabores;
        private Button btnFuncionarios;
        private Button btnClientes;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Label labelUserLogged;
        private Panel panelDesktopPane;
        private Button btnInvisible;
        private Button btnConfiguracoes;
    }
}