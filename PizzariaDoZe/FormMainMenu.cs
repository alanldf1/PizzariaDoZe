using PizzariaDoZe.Properties;
using System.Drawing.Imaging;
using System.Resources;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();

            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private Button? currentButton;
        public Form? activeForm;

        /// <summary>
        /// Ativa o bot�o conforme o formul�rio que foi aberto
        /// </summary>
        /// <param name="btnSender">Puxa o bot�o que foi clicado</param>
        /// <param name="imageName">Nome do icone que vai substuir a icone branca</param>
        private void ActivateButton(object btnSender, string imageName)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(imageName);
                    currentButton = (Button)btnSender;
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
        private void OpenChildForm(Form childForm, object btnSender, string imageName)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Button thisButton = (Button)btnSender;

            if (thisButton.Name != "btnHome")
            {
                activeForm = childForm;
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
                ActivateButton(btnSender, imageName);
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
            OpenChildForm(new Forms.Clientes.tabelaClientes(), sender, "home");
        }

        /// <summary>
        /// Ao apertar o bot�o dos clientes vai abrir o formul�rio dos cliente
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Clientes.tabelaClientes(), sender, "clientes");
        }

        /// <summary>
        /// Ao apertar o bot�o de funcionario vai chamar o formul�rio dos funcionarios
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Funcionarios.tabelaFuncionarios(), sender, "funcionarios");
        }

        /// <summary>
        /// Ao apertar o bot�o dos sabores vai chamar o formul�rio dos sabores
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnSabores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Sabores.tabelaSabores(), sender, "sabores");

        }

        /// <summary>
        /// Ao apertar o bot�o dos ingredientes vai chamar o formul�rio dos ingredientes
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ingredientes.tabelaIngredientes(), sender, "ingredientes");

        }

        /// <summary>
        /// Ao apertar o bot�o das configura��es vai chamar o formul�rio das configura��es
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Configuracoes.telaConfiguracoes(), sender, "configuracoes");
        }

        /// <summary>
        /// Este bot�o vai se adaptar ao formul�rio aberto, vai abrir o formul�rio de cadastro da p�gina aberta
        /// </summary>
        /// <param name="sender">Bot�o clicado</param>
        /// <param name="e"></param>
        private void btnInvisible_Click(object sender, EventArgs e)
        {
            Button? butt = (Button)sender;
            if ((String?)butt.Tag == "Clientes")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Clientes.CadastrarCliente(), sender, "clientes");
            }
            else if ((String?)butt.Tag == "Funcionarios")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Funcionarios.CadastrarFuncionario(), sender, "funcionarios");
            }
            else if ((String?)butt.Tag == "Sabores")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Sabores.CadastrarSabor(), sender, "sabores");
            }
            else if ((String?)butt.Tag == "Ingredientes")
            {
                this.btnInvisible.Visible = false;
                OpenChildForm(new Forms.Ingredientes.CadastrarIngrediente(), sender, "ingredientes");
            }
        }

    }
}