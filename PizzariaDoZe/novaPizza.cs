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

namespace PizzariaDoZe
{
    public partial class novaPizza : UserControl
    {
        private readonly SaborDAO saborDAO;

        public novaPizza(int key)
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
            saborDAO = new SaborDAO(provider, strConnection);
            groupBoxPizza.Name = "groupBoxPizza" + key.ToString();
            groupBoxPizza.Text = "Pizza " + (key+1).ToString();
            CheckedListBox checkedListBox = checkedListBoxSabores;
            checkedListBoxSabores.Name = checkedListBoxSabores + key.ToString();
            CarregaSaboresCheckedListBox(checkedListBox);
        }

        private void radioButtonTamanhoPequeno_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CarregaSaboresCheckedListBox(CheckedListBox checkedListBox)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBox.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBox.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
