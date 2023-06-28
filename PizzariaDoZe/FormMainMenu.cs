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
#pragma warning disable CS1591 // O coment�rio XML ausente n�o foi encontrado para o tipo ou membro vis�vel publicamente
    public partial class FormMainMenu : Form
    {
        /// <summary>
        /// Inicia o formulario
        /// </summary>
        /// 

        public FormMainMenu()
        {
            InitializeComponent();

            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            Funcoes.AjustaResourcesItem(contextMenuStripMain);

            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser automatizadas acima
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
        /// Guarda o bot�o clicado por �ltimo
        /// </summary>
        public Button? currentButton;
        /// <summary>
        /// Vai salvar o formul�rio ativo, ao abrir outro formulario ele ira salvar em cima
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
        /// Ativa o bot�o conforme o formul�rio que foi aberto
        /// </summary>
        /// <param name="btnSender">Puxa o bot�o que foi clicado</param>
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
        /// Desabilita o bot�o que estava ativado anteriormente
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
        /// Abre o formul�rio desejado dentro do painel
        /// </summary>
        /// <param name="childForm">Puxa o formulario desejado</param>
        /// <param name="btnSender">� o bot�o que foi clicado (para ativar e trocar o icone)</param>
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
        /// Ao apertar o bot�o da home ele volta para a home
        /// </summary>
        /// <param name="sender">bot�o que foi cliado</param>
        /// <param name="e">N�o sei</param>
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
        /// Ao apertar o bot�o dos clientes vai abrir o formul�rio dos cliente
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
        /// Ao apertar o bot�o de funcionario vai chamar o formul�rio dos funcionarios
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
        /// Ao apertar o bot�o dos sabores vai chamar o formul�rio dos sabores
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
        /// Ao apertar o bot�o dos ingredientes vai chamar o formul�rio dos ingredientes
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
        /// Ao apertar o bot�o das configura��es vai chamar o formul�rio das configura��es
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
        /// Este bot�o vai se adaptar ao formul�rio aberto, vai abrir o formul�rio de cadastro da p�gina aberta
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
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
            //if (MessageBox.Show(Resources.windowMessage, "Pizzaria do z�",MessageBoxButtons.YesNo) == DialogResult.No)
            if (MessageBox.Show(Resources.windowMessage, "Pizzaria do z�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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