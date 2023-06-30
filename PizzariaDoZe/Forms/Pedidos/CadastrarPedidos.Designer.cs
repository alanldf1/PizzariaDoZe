namespace PizzariaDoZe.Forms.Pedidos
{
    partial class CadastrarPedidos
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
            textBoxCliente = new TextBox();
            labelCliente = new Label();
            labelTelefone = new Label();
            labelCPF = new Label();
            textBoxIdCliente = new TextBox();
            labelId = new Label();
            groupBoxBuscaCliente = new GroupBox();
            buttonSearchClient = new Button();
            maskedTextBoxPhone = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            groupBoxPizzas = new GroupBox();
            flowLayoutPanelPizzas = new FlowLayoutPanel();
            buttonCadastrarPizzas = new Button();
            labelQuantidadePizza = new Label();
            textBoxQuantidadePizzas = new TextBox();
            groupBoxBuscaCliente.SuspendLayout();
            groupBoxPizzas.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCliente
            // 
            textBoxCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxCliente.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCliente.Location = new Point(238, 63);
            textBoxCliente.Margin = new Padding(3, 2, 3, 2);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(376, 28);
            textBoxCliente.TabIndex = 25;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.Location = new Point(233, 38);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(64, 25);
            labelCliente.TabIndex = 1;
            labelCliente.Text = "Cliente:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(108, 102);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(76, 25);
            labelTelefone.TabIndex = 26;
            labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPF.Location = new Point(363, 102);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(41, 25);
            labelCPF.TabIndex = 28;
            labelCPF.Text = "CPF:";
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxIdCliente.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIdCliente.Location = new Point(115, 63);
            textBoxIdCliente.Margin = new Padding(3, 2, 3, 2);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.ReadOnly = true;
            textBoxIdCliente.Size = new Size(89, 28);
            textBoxIdCliente.TabIndex = 31;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(108, 38);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 25);
            labelId.TabIndex = 30;
            labelId.Text = "Id:";
            // 
            // groupBoxBuscaCliente
            // 
            groupBoxBuscaCliente.Controls.Add(buttonSearchClient);
            groupBoxBuscaCliente.Controls.Add(maskedTextBoxPhone);
            groupBoxBuscaCliente.Controls.Add(maskedTextBoxCpf);
            groupBoxBuscaCliente.Controls.Add(textBoxIdCliente);
            groupBoxBuscaCliente.Controls.Add(labelCliente);
            groupBoxBuscaCliente.Controls.Add(labelId);
            groupBoxBuscaCliente.Controls.Add(textBoxCliente);
            groupBoxBuscaCliente.Controls.Add(labelTelefone);
            groupBoxBuscaCliente.Controls.Add(labelCPF);
            groupBoxBuscaCliente.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxBuscaCliente.Location = new Point(168, 28);
            groupBoxBuscaCliente.Name = "groupBoxBuscaCliente";
            groupBoxBuscaCliente.Size = new Size(760, 240);
            groupBoxBuscaCliente.TabIndex = 45;
            groupBoxBuscaCliente.TabStop = false;
            groupBoxBuscaCliente.Text = "Buscar cliente";
            // 
            // buttonSearchClient
            // 
            buttonSearchClient.Location = new Point(290, 183);
            buttonSearchClient.Name = "buttonSearchClient";
            buttonSearchClient.Size = new Size(133, 31);
            buttonSearchClient.TabIndex = 48;
            buttonSearchClient.Text = "Buscar cliente";
            buttonSearchClient.UseVisualStyleBackColor = true;
            buttonSearchClient.Click += buttonSearchClient_Click;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPhone.Location = new Point(115, 130);
            maskedTextBoxPhone.Mask = "(00) 90000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(230, 28);
            maskedTextBoxPhone.TabIndex = 47;
            maskedTextBoxPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpf.Location = new Point(363, 130);
            maskedTextBoxCpf.Mask = " 000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(251, 28);
            maskedTextBoxCpf.TabIndex = 46;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBoxPizzas
            // 
            groupBoxPizzas.Controls.Add(flowLayoutPanelPizzas);
            groupBoxPizzas.Controls.Add(buttonCadastrarPizzas);
            groupBoxPizzas.Controls.Add(labelQuantidadePizza);
            groupBoxPizzas.Controls.Add(textBoxQuantidadePizzas);
            groupBoxPizzas.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPizzas.Location = new Point(168, 286);
            groupBoxPizzas.Name = "groupBoxPizzas";
            groupBoxPizzas.Size = new Size(760, 523);
            groupBoxPizzas.TabIndex = 47;
            groupBoxPizzas.TabStop = false;
            groupBoxPizzas.Text = "Pizzas";
            // 
            // flowLayoutPanelPizzas
            // 
            flowLayoutPanelPizzas.AutoScroll = true;
            flowLayoutPanelPizzas.Location = new Point(33, 110);
            flowLayoutPanelPizzas.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelPizzas.Name = "flowLayoutPanelPizzas";
            flowLayoutPanelPizzas.Size = new Size(692, 364);
            flowLayoutPanelPizzas.TabIndex = 50;
            // 
            // buttonCadastrarPizzas
            // 
            buttonCadastrarPizzas.Location = new Point(314, 55);
            buttonCadastrarPizzas.Name = "buttonCadastrarPizzas";
            buttonCadastrarPizzas.Size = new Size(219, 31);
            buttonCadastrarPizzas.TabIndex = 49;
            buttonCadastrarPizzas.Text = "Cadastrar Pizzas";
            buttonCadastrarPizzas.UseVisualStyleBackColor = true;
            buttonCadastrarPizzas.Click += buttonCadastrarPizzas_Click;
            // 
            // labelQuantidadePizza
            // 
            labelQuantidadePizza.AutoSize = true;
            labelQuantidadePizza.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantidadePizza.Location = new Point(27, 32);
            labelQuantidadePizza.Name = "labelQuantidadePizza";
            labelQuantidadePizza.Size = new Size(163, 25);
            labelQuantidadePizza.TabIndex = 26;
            labelQuantidadePizza.Text = "Quantidade de pizzas:";
            // 
            // textBoxQuantidadePizzas
            // 
            textBoxQuantidadePizzas.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantidadePizzas.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuantidadePizzas.Location = new Point(33, 57);
            textBoxQuantidadePizzas.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantidadePizzas.Name = "textBoxQuantidadePizzas";
            textBoxQuantidadePizzas.Size = new Size(190, 28);
            textBoxQuantidadePizzas.TabIndex = 27;
            // 
            // CadastrarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1121, 839);
            Controls.Add(groupBoxPizzas);
            Controls.Add(groupBoxBuscaCliente);
            Name = "CadastrarPedidos";
            Text = "CadastrarPedidos";
            groupBoxBuscaCliente.ResumeLayout(false);
            groupBoxBuscaCliente.PerformLayout();
            groupBoxPizzas.ResumeLayout(false);
            groupBoxPizzas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxCliente;
        private Label labelCliente;
        private Label labelTelefone;
        private Label labelCPF;
        private TextBox textBoxIdCliente;
        private Label labelId;
        private GroupBox groupBoxBuscaCliente;
        private MaskedTextBox maskedTextBoxPhone;
        private MaskedTextBox maskedTextBoxCpf;
        private Button buttonSearchClient;
        private GroupBox groupBoxPizzas;
        private Button buttonCadastrarPizzas;
        private Label labelQuantidadePizza;
        private TextBox textBoxQuantidadePizzas;
        private FlowLayoutPanel flowLayoutPanelPizzas;
    }
}