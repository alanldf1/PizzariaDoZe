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
using PizzariaDoZe_DAO;

namespace PizzariaDoZe.Forms.Enderecos
{
    public partial class Enderecos : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        public Enderecos()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            //Funcoes.EventoFocoCampos(this);

            //this.ActiveControl = textBoxPesquisa;

            //this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
        }

        private void Enderecos_Load(object sender, EventArgs e)
        {
            this.AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewEnderecos.Columns.Clear();
                dataGridViewEnderecos.AutoGenerateColumns = true;
                dataGridViewEnderecos.DataSource = linhas;
                dataGridViewEnderecos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
