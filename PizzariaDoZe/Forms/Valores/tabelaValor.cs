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

namespace PizzariaDoZe.Forms.Valores
{
    public partial class tabelaValor : Form
    {
        private readonly ValorDAO valorDAO;
        public tabelaValor()
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
            valorDAO = new ValorDAO(provider, strConnection);

            Funcoes.EventoFocoCampos(this);

            this.ActiveControl = textBoxPesquisa;

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void dataGridViewValores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewValores.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Funcao"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());

                e.Value = d.ToString("N2");
            }
        }

        private void tabelaValor_Load(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(valor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewValores.Columns.Clear();
                dataGridViewValores.AutoGenerateColumns = true;
                dataGridViewValores.DataSource = linhas;
                dataGridViewValores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
