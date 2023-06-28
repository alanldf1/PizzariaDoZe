using PizzariaDoZe.Properties;
using System.Drawing.Imaging;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using PizzariaDoZe.Forms.Clientes;
using System.Text.RegularExpressions;
using System.Text;
using System.Configuration;
using System.Data.Common;
using PizzariaDoZe.Forms.Configuracoes;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class FormMainMenu : Form
    {
        /// <summary>
        /// Inicia o formulario
        /// </summary>
        /// 

        public FormMainMenu()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            Funcoes.AjustaResourcesItem(contextMenuStripMain);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            //Menus
            toolStripMenuItemHome.Click += new EventHandler(btnHome_Click!);
            toolStripMenuItemClientes.Click += new EventHandler(btnClientes_Click!);
            toolStripMenuItemFuncionarios.Click += new EventHandler(btnFuncionarios_Click!);
            toolStripMenuItemIngredientes.Click += new EventHandler(btnIngredientes_Click!);
            toolStripMenuItemSabores.Click += new EventHandler(btnSabores_Click!);

            toolStripMenuItemConfig.Click += new EventHandler(btnConfiguracoes_Click!);

            //System Tray
            toolStripMenuItemOpen.Click += new EventHandler(openForm!);
            toolStripMenuItemFinish.Click += new EventHandler(closeForm!);
            toolStripMenuItemAbout.Click += new EventHandler(openForm!);
        }
        /// <summary>
        /// Guarda o botão clicado por último
        /// </summary>
        public Button? currentButton;
        /// <summary>
        /// Vai salvar o formulário ativo, ao abrir outro formulario ele ira salvar em cima
        /// </summary>
        public Form? activeForm;

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void openForm(object sender, EventArgs e)
        {
            this.Show();
            //this.Activate();
        }
        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = true;
        }


        /// <summary>
        /// Ativa o botão conforme o formulário que foi aberto
        /// </summary>
        /// <param name="btnSender">Puxa o botão que foi clicado</param>
        /// <param name="imageName">Nome do icone que vai substuir a icone branca</param>
        /// 
        private void ActivateButton(object btnSender, string imageName)
        {
            if (btnSender != null)
            {

                if (currentButton != (Button)btnSender)
                {
                    DisableButton(imageName);
                    currentButton = (Button)btnSender;
                    Funcoes.lastButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gainsboro;
                    currentButton.ForeColor = Color.FromArgb(76, 10, 1);
                    string path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Resources\\" + imageName + "-red.png";
                    currentButton.Image = System.Drawing.Image.FromFile(@path);
                }
            }
        }
        /// <summary>
        /// Desabilita o botão que estava ativado anteriormente
        /// </summary>
        /// <param name="imageName">Nome do icone que vai substituir a icone vermelha</param>
        private void DisableButton(string imageName)
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {

                if (previousBtn.GetType() == typeof(Button))
                {
                    Button previousButton = (Button)previousBtn;
                    previousButton.BackColor = Color.FromArgb(76, 10, 1);
                    previousButton.ForeColor = Color.Gainsboro;
                    string path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Resources\\" + previousButton.Tag + ".png";
                    previousButton.Image = System.Drawing.Image.FromFile(@path);
                }
            }
        }

        /// <summary>
        /// Abre o formulário desejado dentro do painel
        /// </summary>
        /// <param name="childForm">Puxa o formulario desejado</param>
        /// <param name="btnSender">É o botão que foi clicado (para ativar e trocar o icone)</param>
        /// <param name="imageName">Nome do icone que vai ser ativado</param>
        public void OpenChildForm(Form childForm, object btnSender, string imageName)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Button thisButton = (Button)btnSender;

            if (thisButton.Name != "btnHome")
            {
                activeForm = childForm;
                //childForm.Parent(this);
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                if (thisButton.Name != "btnInvisible" && thisButton.Name != "btnConfiguracoes")
                {

                    String sentenceInvisible = this.btnInvisible.Text;
                    String[] words = sentenceInvisible.Split(" ");
                    String registerInvisible = words[0].ToString();

                    this.btnInvisible.Visible = true;
                    this.btnInvisible.Text = registerInvisible + " " + thisButton.Text.Trim();
                    this.btnInvisible.Tag = thisButton.Tag;
                }
                childForm.BringToFront();
                childForm.Show();



            }
            else
            {
                this.btnInvisible.Visible = false;
            }
            if (thisButton.Name != "btnInvisible")
            {
                if (thisButton.Name != "btnEnderecos")
                {
                    ActivateButton(btnSender, imageName);
                }
                lblTitle.Text = thisButton.Text;
            }
        }
        /// <summary>
        /// Ao apertar o botão da home ele volta para a home
        /// </summary>
        /// <param name="sender">botão que foi cliado</param>
        /// <param name="e">Não sei</param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnHome.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Clientes.tabelaClientes(this), sender, "home");
            }
        }

        /// <summary>
        /// Ao apertar o botão dos clientes vai abrir o formulário dos cliente
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnClientes.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Clientes.tabelaClientes(this), sender, "clientes");
            }

        }

        /// <summary>
        /// Ao apertar o botão de funcionario vai chamar o formulário dos funcionarios
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnFuncionarios.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Funcionarios.tabelaFuncionarios(), sender, "funcionarios");
            }
        }

        /// <summary>
        /// Ao apertar o botão dos sabores vai chamar o formulário dos sabores
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnSabores_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnSabores.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Sabores.tabelaSabores(), sender, "sabores");
            }

        }

        /// <summary>
        /// Ao apertar o botão dos ingredientes vai chamar o formulário dos ingredientes
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnIngredientes.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Ingredientes.tabelaIngredientes(), sender, "ingredientes");
            }

        }

        /// <summary>
        /// Ao apertar o botão das configurações vai chamar o formulário das configurações
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnConfiguracoes.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Configuracoes.telaConfiguracoes(), sender, "configuracoes");
            }
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnValores.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Valores.tabelaValor(), sender, "valores");
            }
        }


        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnValores.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Produtos.tabelaProdutos(), sender, "produtos");
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                btnPedidos.PerformClick();
            }
            else
            {
                OpenChildForm(new Forms.Pedidos.tabelaPedidos(), sender, "pedidos");
            }
        }

        /// <summary>
        /// Este botão vai se adaptar ao formulário aberto, vai abrir o formulário de cadastro da página aberta
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnInvisible_Click(object sender, EventArgs e)
        {
            Button? butt = (Button)sender;
            String buttonTag = (String?)butt.Tag;
            String buttonTagLower = buttonTag.ToLower();
            if (buttonTag == "Clientes")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Clientes.CadastrarCliente(this), sender, buttonTagLower);
            }
            else if (buttonTag == "Funcionarios")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Funcionarios.CadastrarFuncionario(this), sender, buttonTagLower);
            }
            else if (buttonTag == "Sabores")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Sabores.CadastrarSabor(this), sender, buttonTagLower);
            }
            else if (buttonTag == "Ingredientes")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Ingredientes.CadastrarIngrediente(this), sender, buttonTagLower);
            }
            else if (buttonTag == "Valores")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Valores.CadastrarValor(this), sender, buttonTagLower);
            }
            else if (buttonTag == "Produtos")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Produtos.CadastrarProdutos(this), sender, buttonTagLower);
            }
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            //DialogResult resultado = 
            //if (MessageBox.Show(Resources.windowMessage, "Pizzaria do zé",MessageBoxButtons.YesNo) == DialogResult.No)
            if (MessageBox.Show(Resources.windowMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public static void ValidaConexaoDB(Button thisButton)
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                thisButton.PerformClick();
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            Button thisButton = this.btnConfiguracoes;
            ValidaConexaoDB(thisButton);
        }
    }

}