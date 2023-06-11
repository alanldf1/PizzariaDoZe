using PizzariaDoZe.Properties;
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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe.Forms.Clientes
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class CadastrarCliente : Form
    {
        private FormMainMenu _mainForm;
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;

#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarCliente(FormMainMenu mainForm)
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
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);

            _mainForm = mainForm;

            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxName;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;

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
                var cliente = new Cliente
                {
                    Id = 0,
                    Nome = textBoxName.Text,
                    Cpf = maskedTextBoxCpf.Text,
                    Telefone = maskedTextBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    EnderecoId = int.Parse(textBoxIdEndereco.Text),
                    Numero = textBoxNumero.Text,
                    Complemento = textBoxComplemento.Text,
                };
                try
                {
                    // chama o método da model para inserir e capturar o ID do cliente
                    int result = clienteDAO.Inserir(cliente);
                    MessageBox.Show("Dados inseridos com sucesso! " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Close();
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


        /// <summary>
        /// Verifica todos os campos obrigatórios do formulário
        /// </summary>
        /// <returns></returns>
        private bool checkCamps()
        {
            String name = this.textBoxName.Text.Trim();
            String endereco = this.textBoxEndereco.Text.Trim();
            String phone = this.maskedTextBoxPhone.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Preencha o nome do cliente.");
                return false;
            }
            if (phone == "")
            {
                MessageBox.Show("Preencha o telefone do cliente.");
                return false;
            }
            if (endereco == "")
            {
                MessageBox.Show("Preencha o endereco do cliente.");
                return false;
            }

            return true;
        }


        private void CadastrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(Resources.pageMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        private void maskedTextBoxCep_TextChanged(object sender, EventArgs e)
        {
            string cep = maskedTextBoxCep.Text.Trim();
            if (cep.Length == 8) // Verifica se o CEP possui a quantidade correta de caracteres
            {
                // Realize aqui a lógica para buscar o CEP
                // Chame a função ou método para buscar o CEP com base no valor digitado
                BuscarCep(cep);
            }
        }

        private void BuscarCep(string cep)
        {
            var endereco = new Endereco
            {
                Cep = cep,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                textBoxEndereco.Text = "";
                textBoxIdEndereco.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                string enderecoCompleto = "";
                foreach (DataRow row in linhas.Rows)
                {
                    enderecoCompleto = row["logradouro"].ToString() + ", " +
                        row["bairro"].ToString() + ", " +
                        row["cidade"].ToString() + " - " +
                        row["uf"].ToString() + ", " +
                        row["pais"].ToString();
                    //userControlEndereco.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    textBoxIdEndereco.Text = row["id"].ToString();
                }
                textBoxEndereco.Text = enderecoCompleto;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
