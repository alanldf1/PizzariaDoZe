using PizzariaDoZe_DAO;
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

namespace PizzariaDoZe.Forms.Produtos
{
    public partial class CadastrarProdutos : Form
    {
        private FormMainMenu _mainForm;
        private ProdutosDAO produtosDAO;

        public CadastrarProdutos(FormMainMenu mainForm)
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
            produtosDAO = new ProdutosDAO(provider, strConnection);

            _mainForm = mainForm;
            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxNome;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;

            CarregaEnumListBox();
            _mainForm = mainForm;
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
                var produto = new Produto
                {
                    Id = 0,
                    Nome = textBoxNome.Text,
                    Descricao = textBoxDescricao.Text,
                    Valor = decimal.Parse(textBoxValor.Text),
                    Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                    ML = listBoxML.Text,
                };
                try
                {
                    // chama o método para inserir da camada model
                    produtosDAO.Inserir(produto);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //Close();
                }
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

        private void CadastrarSabor_FormClosing(object sender, FormClosingEventArgs e)
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
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
    }
}
