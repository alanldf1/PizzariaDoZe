using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.Properties;
using PizzariaDoZe_DAO;

namespace PizzariaDoZe.Forms.Valores
{
    public partial class CadastrarValor : Form
    {

        private readonly ValorDAO valorDAO;
        private readonly SaborDAO saborDAO;
        private FormMainMenu _mainForm;
        public CadastrarValor(FormMainMenu mainForm)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);

            _mainForm = mainForm;
            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxValor;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;

            CarregaEnumListBox();
        }


        public bool checkCamps()
        {
            return true;
        }

        /// <summary>
        /// Faz a verificação e envia os dados do formulario
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean check = checkCamps();
            if (check)
            {
                //Instância e Preenche o objeto com os dados da view
                var valor = new Valor
                {
                    Id = 0,
                    Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                    Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                    ValorPizza = decimal.Parse(textBoxValor.Text),
                    ValorBorda = decimal.Parse(textBoxValorBorda.Text),
                };
                try
                {
                    // chama o método para inserir da camada model
                    valorDAO.Inserir(valor);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Close();
            }
            else
            {
                _mainForm.btnHome.PerformClick();
            }
        }

        /// <summary>
        /// Botão fecha o formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentButton.Text);
            //_mainForm.activeForm = null;
            //Close();
            _mainForm.btnHome.PerformClick();

        }

        private void CadastrarValor_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(Resources.pageMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void CadastrarValor_Load(object sender, EventArgs e)
        {
            textBoxValor.Focus();
        }
    }
}
