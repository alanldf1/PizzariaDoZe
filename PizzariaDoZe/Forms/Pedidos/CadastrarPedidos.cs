using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PizzariaDoZe.Forms.Pedidos
{
    public partial class CadastrarPedidos : Form
    {
        private readonly ClienteDAO clienteDAO;
        private readonly PedidoDAO pedidoDAO;
        private readonly SaborDAO saborDAO;

        private FormMainMenu _mainForm;
        private Control ultimoTextBoxDigitado;
        private int quantidadeAtualPizzas = 0;
        public CadastrarPedidos(FormMainMenu mainForm)
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
            clienteDAO = new ClienteDAO(provider, strConnection);
            pedidoDAO = new PedidoDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            _mainForm = mainForm;
            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxCliente;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            textBoxCliente.Enter += TextBox_Enter;
            maskedTextBoxPhone.Enter += TextBox_Enter;
            maskedTextBoxCpf.Enter += TextBox_Enter;

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {

            ultimoTextBoxDigitado = (Control)sender;
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            string nome = textBoxCliente.Text.Trim();
            string telefone = maskedTextBoxPhone.Text.Trim();
            string cpf = maskedTextBoxCpf.Text.Trim();
            // Realize aqui a lógica para buscar o cliente
            // Chame a função ou método para buscar o cliente com base nos valores digitados
            BuscarCliente(nome, telefone, cpf);

        }

        private void LimparCamposDoGroupBox(System.Windows.Forms.GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBoxBase textBox && textBox != ultimoTextBoxDigitado)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void BuscarCliente(string nome, string telefone, string cpf)
        {

            var cliente = new Cliente
            {
                Nome = nome,
                Telefone = telefone,
                Cpf = cpf
            };

            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                //userControlEndereco.maskedTextBoxCep.Text = "";
                if (linhas.Rows.Count > 0)
                {
                    LimparCamposDoGroupBox(groupBoxBuscaCliente); // Limpa os campos de texto dentro do groupBox1
                    foreach (DataRow row in linhas.Rows)
                    {
                        textBoxIdCliente.Text = row["id"].ToString();
                        textBoxCliente.Text = row["nome"].ToString();
                        maskedTextBoxPhone.Text = row["telefone"].ToString();
                        maskedTextBoxCpf.Text = row["cpf"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado, preencha todos os dados para cadastrar um novo cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCadastrarPizzas_Click(object sender, EventArgs e)
        {
            // Verifique se o valor digitado é um número válido
            if (int.TryParse(textBoxQuantidadePizzas.Text, out int quantidadePizzas))
            {
                // Calcule a diferença entre a quantidade atual e a quantidade desejada
                int diferenca = quantidadePizzas - quantidadeAtualPizzas;

                if (diferenca > 0)
                {
                    // Adicione painéis adicionais
                    for (int i = 0; i < diferenca; i++)
                    {
                        // Crie um novo painel para a pizza
                        Panel panelPizza = new Panel();
                        panelPizza.Name = $"panelPizza{i}";
                        panelPizza.Location = new Point(10, (quantidadeAtualPizzas + i) * 150); // Defina a posição do painel na tela
                        panelPizza.Size = new Size(300, 140); // Defina o tamanho do painel

                        Label label = new Label();
                        label.Text = $"Pizza {quantidadeAtualPizzas + i}";
                        // Adicione os controles desejados ao painel
                        System.Windows.Forms.ComboBox comboBoxTamanho = new System.Windows.Forms.ComboBox();
                        comboBoxTamanho.Name = $"comboBoxTamanho{quantidadeAtualPizzas + i}";
                        comboBoxTamanho.Location = new Point(10, 70);
                        comboBoxTamanho.Width = 100;
                        comboBoxTamanho.Items.AddRange(new string[] { "Pequeno", "Médio", "Grande" });
                        // Adicione outros controles, como ComboBoxes, Labels, etc.
                        System.Windows.Forms.CheckedListBox checkedListBoxSabor = new CheckedListBox();
                        checkedListBoxSabor.Name = $"checkedListBoxSabor{quantidadeAtualPizzas + i}";
                        //checkedListBoxSabor.Location = new Point(10, 120);
                        checkedListBoxSabor.Dock = DockStyle.Fill;
                        checkedListBoxSabor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        // Defina o item pré-selecionado pelo índice
                        comboBoxTamanho.SelectedIndex = 1; // Seleciona o item "Médio"

                        panelPizza.Controls.Add(label);
                        panelPizza.Controls.Add(comboBoxTamanho);
                        panelPizza.Controls.Add(checkedListBoxSabor);
                        CarregaSaboresCheckedListBox(checkedListBoxSabor);

                        // Adicione outros controles ao painel

                        // Adicione o painel ao controle pai (por exemplo, um Form ou outro painel)
                        flowLayoutPanelPizzas.Controls.Add(panelPizza);
                    }
                }
                else if (diferenca < 0)
                {
                    // Remova painéis extras
                    for (int i = quantidadeAtualPizzas - 1; i >= quantidadePizzas; i--)
                    {
                        Control control = flowLayoutPanelPizzas.Controls[$"panelPizza{i}"];
                        flowLayoutPanelPizzas.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                // Atualize a quantidade atual
                quantidadeAtualPizzas = quantidadePizzas;
            }
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
