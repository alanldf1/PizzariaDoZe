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

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private Button? currentButton;
        public Form? activeForm;

        /// <summary>
        /// Ativa o botão conforme o formulário que foi aberto
        /// </summary>
        /// <param name="btnSender">Puxa o botão que foi clicado</param>
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
        /// Ao apertar o botão da home ele volta para a home
        /// </summary>
        /// <param name="sender">botão que foi cliado</param>
        /// <param name="e">Não sei</param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Clientes.tabelaClientes(), sender, "home");
        }

        /// <summary>
        /// Ao apertar o botão dos clientes vai abrir o formulário dos cliente
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Clientes.tabelaClientes(), sender, "clientes");
        }

        /// <summary>
        /// Ao apertar o botão de funcionario vai chamar o formulário dos funcionarios
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Funcionarios.tabelaFuncionarios(), sender, "funcionarios");
        }

        /// <summary>
        /// Ao apertar o botão dos sabores vai chamar o formulário dos sabores
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnSabores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Sabores.tabelaSabores(), sender, "sabores");

        }

        /// <summary>
        /// Ao apertar o botão dos ingredientes vai chamar o formulário dos ingredientes
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ingredientes.tabelaIngredientes(), sender, "ingredientes");

        }

        /// <summary>
        /// Ao apertar o botão das configurações vai chamar o formulário das configurações
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Configuracoes.telaConfiguracoes(), sender, "configuracoes");
        }

        /// <summary>
        /// Este botão vai se adaptar ao formulário aberto, vai abrir o formulário de cadastro da página aberta
        /// </summary>
        /// <param name="sender">Botão clicado</param>
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