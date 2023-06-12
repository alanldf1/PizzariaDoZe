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

namespace PizzariaDoZe.Forms.Produtos
{
    public partial class tabelaProdutos : Form
    {
        private ProdutosDAO produtosDAO;
        public tabelaProdutos()
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
            produtosDAO = new ProdutosDAO(provider, strConnection);

            Funcoes.EventoFocoCampos(this);

            this.ActiveControl = textBoxPesquisa;

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

        }

        private void dataGridViewProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewProdutos.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Tipo Produto"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var produtos = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtosDAO.Buscar(produtos);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabelaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarTela();
        }
    }
}
