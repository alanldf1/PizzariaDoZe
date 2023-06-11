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

namespace PizzariaDoZe.Forms.Clientes
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class tabelaClientes : Form
    {
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        private FormMainMenu formMainMenu;
        private ClienteDAO clienteDAO;
        public tabelaClientes(FormMainMenu formMainMenu)
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
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);

            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxPesquisa;

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            this.formMainMenu = formMainMenu;


        }

        private void btnEnderecos_Click(object sender, EventArgs e)
        {
            formMainMenu.OpenChildForm(new Forms.Enderecos.Enderecos(), sender, "Enderecos");
        }

        private void tabelaClientes_Load(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewClientes.Columns.Clear();
                dataGridViewClientes.AutoGenerateColumns = true;
                dataGridViewClientes.DataSource = linhas;
                dataGridViewClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
